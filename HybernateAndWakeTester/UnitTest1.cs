using Microsoft.VisualStudio.TestTools.UnitTesting;
using HybernateAndWake.Setup;
using System.Runtime.Versioning;

namespace HybernateAndWakeTester
{

    [TestClass, SupportedOSPlatform("Windows")]
    public class UnitTest1
    {
        [TestMethod]
        public void AutoLogonTest()
        {
            AutoLoggon.ConfigureAutologon("2304");
        }
    }
}