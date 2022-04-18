using ConfigAndLoader;
using HybernateAndWake.Utils;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;
using SchedulerTask = Microsoft.Win32.TaskScheduler.Task;
using System.Runtime.Versioning;

namespace HybernateAndWake.Setup
{
    [SupportedOSPlatform("Windows")]
    public static class Scheduler
    {
        static readonly string wakeTaskName = "WakeTask-BA057052-DDB6-4A2C-8E69-321914885C96";
        static readonly string sleepTaskName = "SleepTask-888B19AD-7C4B-41AB-B7B5-0D0B7B401C47";
        static readonly string restartTaskName = "RestartTask-1BFE57D9-2FBA-41CF-80F2-A96DA107D469";

        static readonly string wakeTaskTestName = "WakeTaskTmp-1BFE57D9-2FBA-41CF-80F2-A96DA107D469";
        static readonly string sleepTaskTestName = "SleepTaskTmp-7FB0E433-5BDD-431D-A561-E670F5BDD7F6"; 
        static readonly string restartTaskTestName = "RestartTaskTmp-F6A7C928-1068-409B-B18B-6C81DD1D8088"; 

        public static async void ListTasksInCmd()
        {
            using TaskService taskService = new TaskService();
            string command = string.Join("\necho " ,taskService.RootFolder.AllTasks.Select(s => s.Name));

            Shell shell = new Shell();
            shell.ExcecuteShellCommand(ShellType.Cmd, command, false);
        }

        public static void SetScheduleUsingConfig()
        {
            Config config = Loader.GetConfig();

            DaysOfTheWeek? wakeDays = DaysOfTheWeek.Monday;
            wakeDays -= DaysOfTheWeek.Monday;

            if (config.monday)
                wakeDays |= DaysOfTheWeek.Monday;
            if (config.tuesday)
                wakeDays |= DaysOfTheWeek.Tuesday;
            if (config.wednesday)
                wakeDays |= DaysOfTheWeek.Wednesday;
            if (config.thursday)
                wakeDays |= DaysOfTheWeek.Thursday;
            if (config.friday)
                wakeDays |= DaysOfTheWeek.Friday;
            if (config.saturday)
                wakeDays |= DaysOfTheWeek.Saturday;
            if(config.sunday)
                wakeDays |= DaysOfTheWeek.Sunday;

            TaskService taskService = new TaskService();
            taskService.BeginInit();

            while (!taskService.Connected)
                Task.Delay(1).GetAwaiter().GetResult();

            //Make tasks
            if (wakeDays != null)
            {
                //Wake
                TaskDefinition wakeTask = MakeTask(wakeDays.Value, config.wakeTime, "exit", ref taskService);
                ConfigureWakeTaskSettings(ref wakeTask);

                taskService.RootFolder.RegisterTaskDefinition(wakeTaskName, wakeTask);
                wakeTask.Dispose();

                //Restart
                TaskDefinition restartTask = MakeTask(wakeDays.Value, config.wakeTime + TimeSpan.FromMinutes(30), "shutdown /r /t 60", ref taskService);
                taskService.RootFolder.RegisterTaskDefinition(restartTaskName, restartTask);
                restartTask.Dispose();

                //Sleep
                TaskDefinition sleepTask = MakeTask(DaysOfTheWeek.AllDays, config.sleepTime, "shutdown /h", ref taskService);
                taskService.RootFolder.RegisterTaskDefinition(sleepTaskName, sleepTask);
                sleepTask.Dispose();

                ValidateExistance();
            }
            else
            {
                DisableSchedule();
            }

            taskService.Dispose();
        }

        public static void DisableSchedule()
        {
            using TaskService taskService = new TaskService();
            List<SchedulerTask> tasks = taskService.AllTasks.ToList();

            SchedulerTask? wake = tasks.Find(s => s.Name == wakeTaskName);
            if (wake != null)
            {
                wake.Enabled = false;
            }

            SchedulerTask? sleep = tasks.Find(s => s.Name == sleepTaskName);
            if(sleep != null)
            {
                sleep.Enabled = false;
            }

            SchedulerTask? restart = tasks.Find(s => s.Name == restartTaskName);
            if(restart != null)
            {
                restart.Enabled = false;
            }
        }

        public static void ClearTestTasks()
        {
            using TaskService taskService = new TaskService();
            taskService.RootFolder.DeleteTask(wakeTaskTestName, false);
            taskService.RootFolder.DeleteTask(sleepTaskTestName, false);
            taskService.RootFolder.DeleteTask(restartTaskTestName, false);
        }

        static void ValidateExistance()
        {
            using TaskService taskService = new TaskService();
            
            if(taskService.FindTask(wakeTaskName) == null)
            {
                throw new Exception();
            }

            if(taskService.FindTask(sleepTaskName) == null)
            {
                throw new Exception();
            }

            if(taskService.FindTask(restartTaskName) == null)
            {
                throw new Exception();
            }
        }

        static void ConfigureWakeTaskSettings(ref TaskDefinition definition)
        {
            definition.Settings.Compatibility = TaskCompatibility.V2_2 | TaskCompatibility.V2_3;
            //definition.Settings.RunOnlyIfLoggedOn = false;
            definition.Settings.WakeToRun = true;
            definition.Settings.Priority = System.Diagnostics.ProcessPriorityClass.High;
            definition.Principal.RunLevel = TaskRunLevel.Highest;
        }

        public static async Task TestWakeAsync()
        {
            TaskService taskService = new TaskService();

            TaskDefinition wakeTask = MakeTask(DaysOfTheWeek.AllDays, DateTime.Now + TimeSpan.FromMinutes(2), "exit", ref taskService);
            ConfigureWakeTaskSettings(ref wakeTask);
            wakeTask.Settings.Volatile = true;

            taskService.RootFolder.RegisterTaskDefinition(wakeTaskTestName, wakeTask);
            
            taskService.Dispose();
            wakeTask.Dispose();

            await Task.Delay(60 * 1000);

            Shell shell = new();
            await shell.ExcecuteShellCommand(ShellType.Cmd, "shutdown /h", false);
        }

        public static async Task TestSleepAsync()
        {
            TaskService taskService = new TaskService();

            TaskDefinition sleepTask = MakeTask(DaysOfTheWeek.AllDays, DateTime.Now + TimeSpan.FromMinutes(1), "shutdown /h", ref taskService);
            sleepTask.Settings.Volatile = true;
            taskService.RootFolder.RegisterTaskDefinition(sleepTaskTestName, sleepTask);
            
            sleepTask.Dispose();
            taskService.Dispose();
        }

        public static async Task TestRestartAsync()
        {
            TaskService taskService = new TaskService();

            TaskDefinition restartTask = MakeTask(DaysOfTheWeek.AllDays, DateTime.Now + TimeSpan.FromSeconds(10), "shutdown /r", ref taskService);
            restartTask.Settings.Volatile = true;
            taskService.RootFolder.RegisterTaskDefinition(restartTaskTestName, restartTask);

            restartTask.Dispose();
            taskService.Dispose();
        }

        static TaskDefinition MakeTask(DaysOfTheWeek daysOfTheWeek, DateTime when, string cmdArgs, ref TaskService taskService)
        {
            TaskDefinition definition = taskService.NewTask();

            //
            WeeklyTrigger trigger = new WeeklyTrigger(daysOfTheWeek);
            trigger.StartBoundary = when;

            //Triggers
            definition.Triggers.Add(trigger);

            //Action
            definition.Actions.Add("cmd.exe", "/c " + cmdArgs, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            //Misc
            definition.Settings.Hidden = false;
            definition.RegistrationInfo.Author = CurrentUser.GetUsername();
            definition.Settings.Enabled = true;

            return definition;
        }
    }
}
