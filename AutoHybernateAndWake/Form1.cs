using ConfigAndLoader;
using HybernateAndWake.Setup;
using System.Runtime.Versioning;

namespace AutoHybernateAndWake
{
    [SupportedOSPlatform("Windows")]
    public partial class Form1 : Form
    {
        Config config;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveSleepWakeTime_Click(object sender, EventArgs e)
        {
            //Checkboxes
            config.monday = MondayCheckbox.Checked;
            config.tuesday = TuesdayCheckbox.Checked;
            config.wednesday = WednesdayCheckbox.Checked;
            config.thursday = ThursdayCheckbox.Checked;
            config.friday = FridayCheckbox.Checked;
            config.saturday = SaturedayCheckbox.Checked;
            config.sunday = SundayCheckbox.Checked;
            config.enableRestart = AutoRestartCheckbox.Checked;

            //Times
            config.wakeTime = WakeTimePicker.Value;
            config.sleepTime = SleepTimePicker.Value;

            Loader.SaveConfig(config);
        }

        private void SaveAutoLogonPassword_Click(object sender, EventArgs e)
        {
            AutoLoggon.UpdatePassword(PasswordTextbox.Text);
            PasswordTextbox.Text = String.Empty;
        }

        private void DisableAutoLogon_Click(object sender, EventArgs e)
        {
            AutoLoggon.DisableAutoLogon();
        }

        private void EnableAutoLogon_Click(object sender, EventArgs e)
        {
            AutoLoggon.EnableAutoLogon();
        }

        private void SleepAndWakeEnableButton_Click(object sender, EventArgs e)
        {
            Scheduler.SetScheduleUsingConfig();
        }

        private void SleepAndWakeDisableButton_Click(object sender, EventArgs e)
        {
            Scheduler.DisableSchedule();
        }

        private void TestWakeButton_Click(object sender, EventArgs e)
        {
            if(ConfirmationDialog())
            {
                Scheduler.TestWakeAsync();
                TestWakeButton.Enabled = false;
                TestSleepButton.Enabled = false;
                TestRestartButton.Enabled = false;

                CountDownAsync();
            }
        }

        private void TestSleepButton_Click(object sender, EventArgs e)
        {
            if (ConfirmationDialog())
            {
                Scheduler.TestSleepAsync();
                TestWakeButton.Enabled = false;
                TestSleepButton.Enabled = false;
                TestRestartButton.Enabled = false;

                CountDownAsync();
            }
        }

        private void TestRestartButton_Click(object sender, EventArgs e)
        {
            if (ConfirmationDialog())
            {
                Scheduler.TestRestartAsync();
                TestWakeButton.Enabled = false;
                TestSleepButton.Enabled = false;
                TestRestartButton.Enabled = false;

                CountDownAsync();
            }
        }

        async Task CountDownAsync()
        {
            for (int i = 0; i < 121; i++)
            {
                await Task.Delay(1000);
                TestProgressbar.PerformStep();
            }

            TestWakeButton.Enabled = true;
            TestSleepButton.Enabled = true;
            TestRestartButton.Enabled = true;
        }

        bool ConfirmationDialog()
        {
            return MessageBox.Show(text: "Are you sure?", caption: "Confirmation", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config = Loader.GetConfig();
            Scheduler.ClearTestTasks();

            //Checkboxes
            MondayCheckbox.Checked = config.monday;
            TuesdayCheckbox.Checked = config.tuesday;
            WednesdayCheckbox.Checked = config.wednesday;
            ThursdayCheckbox.Checked = config.thursday;
            FridayCheckbox.Checked = config.friday;
            SaturedayCheckbox.Checked = config.saturday;
            SundayCheckbox.Checked = config.sunday;
            AutoRestartCheckbox.Checked = config.enableRestart;

            WakeTimePicker.Value = config.wakeTime;
            SleepTimePicker.Value = config.sleepTime;


            //This is where i will load stuff
            SleepTimePicker.Format = DateTimePickerFormat.Time;
            SleepTimePicker.ShowUpDown = true;


            //This is where i will load stuff
            WakeTimePicker.Format = DateTimePickerFormat.Time;
            WakeTimePicker.ShowUpDown = true;

        }

        
    }
}