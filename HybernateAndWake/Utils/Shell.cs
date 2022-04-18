using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybernateAndWake.Utils
{
    public class Shell : IShell
    {
        public async Task ExcecuteShellCommand(ShellType shellType, string command, bool autoExit = true)
        {
            Process shellProcess = new Process();
            shellProcess.StartInfo.FileName = GetShellName(shellType);
            shellProcess.StartInfo.Arguments = "/c " + command;

            if (autoExit)
                shellProcess.StartInfo.Arguments += " /c" + "exit /c";

            shellProcess.Start();

            shellProcess.WaitForExit();
        }

        public async Task ExcecuteAdminCommand(ShellType shellType, string command, bool autoExit = true)
        {
            Process shellProcess = new Process();
            shellProcess.StartInfo.FileName = GetShellName(shellType);
            shellProcess.StartInfo.Verb = "runas";
            shellProcess.StartInfo.Arguments = "/c " + command;

            if (autoExit)
                shellProcess.StartInfo.Arguments += " /c" + "exit /c";

            shellProcess.Start();

            shellProcess.WaitForExit();
        }

        string GetShellName(ShellType type)
        {
            return type switch
            {
                ShellType.Bash => "Terminal",
                ShellType.Cmd => "cmd",
                ShellType.PowerShell => "powershell",
                _ => "",
            };
        }
    }
}
