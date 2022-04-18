using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybernateAndWake.Utils
{
    public interface IShell
    {
        Task ExcecuteShellCommand(ShellType shellType, string command, bool autoExit);
        Task ExcecuteAdminCommand(ShellType shellType, string command, bool autoExit);
    }
}
