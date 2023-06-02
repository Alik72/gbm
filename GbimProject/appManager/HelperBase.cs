using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class HelperBase
    {
        public IWebDriver wd;
        public ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            wd = manager.Driver;
            this.manager = manager;
        }

        public void DoubleClick(By locator)
        {
            IWebElement element = wd.FindElement(locator);
            element.Click();
            element.Click();
        }
        public void Click(By locator)
        {
            wd.FindElement(locator).Click();
        }
        public void ClickSendKeys(By locator, String type)
        {
            wd.FindElement(locator).Click();
            wd.FindElement(locator).SendKeys(type);
        }
        public void Type(By locator, String type)
        {
            Click(locator);
            wd.FindElement(locator).Clear();
            wd.FindElement(locator).SendKeys(type);
        }
        public static void SleepSec(int s)
        {
            Thread.Sleep(s * 1000);
        }
    }   
}