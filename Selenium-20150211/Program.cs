using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTests;

namespace Selenium_20150211
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationsSystemAudit osaudit = new OperationsSystemAudit();
            osaudit.SetupTest();
            osaudit.TheOperationsSystemAuditTest();
            osaudit.TeardownTest();
        }
    }
}
