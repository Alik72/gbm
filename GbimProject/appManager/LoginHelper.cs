using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace WebGbimTests
{
    public class LoginHelper : HelperBase 
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Login(AccountDate account)
        {
            Click(By.XPath("//div/button"));
            EZP(account);
        }

        private void EZP(AccountDate account)
        {
            Thread.Sleep(5000);
            InputSimulator sim = new InputSimulator();
            Thread.Sleep(500);
            sim.Keyboard.TextEntry(account.Userezp);
            Thread.Sleep(2000);
            // submit enter 
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            Thread.Sleep(2000);
            // Enter Password 
            sim.Keyboard.TextEntry(account.Password);
            // submit enter 
            Thread.Sleep(2000);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            Thread.Sleep(2000);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
    }

    
}
