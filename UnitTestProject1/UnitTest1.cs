using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

using OpenQA.Selenium;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver Driver;

        [Test]

        public void GoogleTest()

        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://www.google.com");

            Driver.FindElement(By.Name("q")).SendKeys("Selenium");

            System.Threading.Thread.Sleep(5000);

            Driver.FindElement(By.Name("btnK")).Click();


            Driver.Close();


        }



        [Test]

        public void ExecuteAutomationTest()

        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://executeautomation.com");

            System.Threading.Thread.Sleep(2000);

            Driver.Close();


        }





    }

}
    