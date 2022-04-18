using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;

namespace HybernateAndWake.Utils
{
    [SupportedOSPlatform("Windows")]
    public class CurrentUser
    {
        public static string GetUsername()
        {
            using WindowsIdentity identity = WindowsIdentity.GetCurrent();
            return identity.Name;
        }

        public static string GetDomainName()
        {
            try
            {
                Domain domain = Domain.GetComputerDomain();
                return domain.Name;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static bool HasPrivlage()
        {
            using WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
