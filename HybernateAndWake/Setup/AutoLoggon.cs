using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Security.Claims;
using HybernateAndWake.Utils;

namespace HybernateAndWake.Setup
{
    [SupportedOSPlatform("Windows")]
    public class AutoLoggon
    {
        static readonly string WinlogonRegPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
        static readonly string defaultPassword = "DefaultPassword";
        static readonly string defaultUserName = "DefaultUserName";
        static readonly string autoAdminLogon = "AutoAdminLogon";
        static readonly string defaultDomainName = "DefaultDomainName";

        [Obsolete]
        public static void ConfigureAutologon(string password)
        {
            if(!CurrentUser.HasPrivlage())
            {
                throw new InvalidOperationException("This operation needs elevated privlage to run.");
            }

            //Source: https://get-cmd.com/?p=4679
            string username = CurrentUser.GetUsername();
            string domain = CurrentUser.GetDomainName();

            List<Task> registryOperations = new List<Task>();

            if (domain != string.Empty)
            {
                registryOperations.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultDomainName, domain)));
            }

            registryOperations.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultPassword, password)));
            registryOperations.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultUserName, username)));
            registryOperations.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, autoAdminLogon, 1)));

            //Block until done
            Task.WaitAll(registryOperations.ToArray());
        }
        
        public static void UpdatePassword(string password)
        {
            Registry.SetValue(WinlogonRegPath, defaultPassword, password);
        }

        public static void EnableAutoLogon()
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, autoAdminLogon, 1)));
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultUserName, CurrentUser.GetUsername().Split("\\").Last())));

            if (CurrentUser.GetDomainName() != string.Empty)
                tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultDomainName, CurrentUser.GetDomainName())));

            Task.WaitAll(tasks.ToArray());
        }

        public static void EnableAutoLogon(string password)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, autoAdminLogon, 1)));
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultDomainName, CurrentUser.GetDomainName())));
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultUserName, CurrentUser.GetUsername())));
            tasks.Add(Task.Run(() => Registry.SetValue(WinlogonRegPath, defaultPassword, password)));

            Task.WaitAll(tasks.ToArray());
        }

        public static void DisableAutoLogon()
        {
            Registry.SetValue(WinlogonRegPath, autoAdminLogon, 0);
        }

        public static void RemoveAutoLogon()
        {
            DeleteValue(WinlogonRegPath, autoAdminLogon);
            DeleteValue(WinlogonRegPath, defaultDomainName);
            DeleteValue(WinlogonRegPath, defaultUserName);
            DeleteValue(WinlogonRegPath, defaultPassword);
        }

        static void DeleteValue(string keyName, string valueName)
        {
            using RegistryKey? key = keyName.Split("\\").First() switch
            {
                "HKEY_CLASSES_ROOT" => Registry.ClassesRoot.OpenSubKey(keyName),
                "HKEY_CURRENT_USER" => Registry.CurrentUser.OpenSubKey(keyName),
                "HKEY_LOCAL_MACHINE" => Registry.LocalMachine.OpenSubKey(keyName),
                "HKEY_USERS" => Registry.Users.OpenSubKey(keyName),
                "HKEY_CURRENT_CONFIG" => Registry.CurrentConfig.OpenSubKey(keyName),
                _ => throw new NotImplementedException($"{keyName.Split("\\").First()} might not exist."),
            };

            if (key == null)
                return;

            key.DeleteValue(valueName);
        }
    }
}
