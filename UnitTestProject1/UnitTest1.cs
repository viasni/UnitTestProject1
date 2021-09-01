using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Configuration;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            Console.WriteLine((int)BrowserType.Firefox);
            Console.WriteLine((int)BrowserType.Chrome);
        }
    }
}
