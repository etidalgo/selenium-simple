using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Selenium_20150211
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationsSystemAudit<InternetExplorerDriver> osaudit = new OperationsSystemAudit<InternetExplorerDriver>();
            osaudit.SetupTest();
            osaudit.TheOperationsSystemAuditTest();
            osaudit.TeardownTest();
        }
    }
}
