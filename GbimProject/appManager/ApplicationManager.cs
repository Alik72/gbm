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
    public class ApplicationManager
    {
        public IWebDriver wd;
        private LoginHelper loginHelper;
        private NavigationHelper navigator;
        private ProjectHelper projectHelper;
        WorkingGroupHelper workingGroupHelper;
        public ApplicationManager()
        {
            wd = new ChromeDriver();
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            wd.Navigate().GoToUrl("http://gbim-frontend.kz/main/projects");
            wd.Manage().Window.Maximize();
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this);
            projectHelper = new ProjectHelper(this);
            workingGroupHelper = new WorkingGroupHelper(this);
        }

        public LoginHelper Auth { get => loginHelper;  }
        public NavigationHelper Navigator { get => navigator;  }
        public ProjectHelper Projects { get => projectHelper;  }
        public IWebDriver Driver { get => wd; }
        public WorkingGroupHelper WorkingGroupHelper { get => workingGroupHelper;}

        public void Stop()
        {
            try
            {
                wd.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
