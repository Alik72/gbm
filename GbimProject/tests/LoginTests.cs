using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace WebGbimTests
{
    [TestFixture]
    public class LoginTests : TestBase

    {
        [Test]
        // авторизация с корретными данными
        public void LoginWhithValidCredentials()
        {
            foreach (String sad in ConfigurationManager.AppSettings)
            {
                Console.WriteLine(sad + " - " + ConfigurationManager.AppSettings[sad]);
            }
             

            AccountDate account = new AccountDate("AUTH_RSA256_f7f812cf2d74093e4c6555bf830b30a44bbb205b.p12", "Qwerty12*");
            //app.Navigator.OpenHomePage();
            app.Auth.Login(account, "Открыть файл");
            // app.Auth.Logout();
            // app.Auth.Login(account);
            //Assert.IsTrue(app.Auth.IsLoggedIn(account));
            //app.Navigator
            // .GoToTypeCustomer()
            //.GoToProjectPage();

            //Console.WriteLine(NumberCreatedProjects(10000));
            app.Navigator
                .GoToPreProjectStageTEO()
                .GoToTabKVE();
            //IWebElement element = wd.FindElement(By.CssSelector("li.p-dropdown-item"));
            //SelectElement select = new SelectElement(element);
            //System.Console.Out.WriteLine("hgfhghg");
            //select.SelectByIndex(1);



        }

        public int NumberCreatedProjects(int sleep)
        {

            Thread.Sleep(sleep);
            String[] text = app.driver.FindElement(By.CssSelector("span.p-paginator-current.ng-star-inserted"))
                             .GetAttribute("textContent").Split(" ");
            
            return Int32.Parse(new Regex(@"\D").Replace(text[2], ""));
        }
        //public void FindWindow(string nameWindow)
       // {
       //     [DllImport("user32.dll", SetLastError = true)]
        //    static extern IntPtr FindWindow(string? sClassName, string sWindowName);
        //    //Находим родителя дескриптора 
        //    IntPtr thisWindow = FindWindow(null, "Открыть файл");
        //    IntPtr Rod = thisWindow;
         //   Console.WriteLine(thisWindow);//дескриптор родителя
       // }
       // public bool FindWindows(string nameWindow)
        //{
        //    [DllImport("user32.dll", SetLastError = true)]
         //   static extern IntPtr FindWindow(string? sClassName, string nameWindow);
            //Находим родителя дескриптора 
         //   IntPtr thisWindow = FindWindow(null, nameWindow);
         //   Console.WriteLine(thisWindow);//дескриптор родителя
         //   return (int)thisWindow > 0;

       // }
       
    }
}
