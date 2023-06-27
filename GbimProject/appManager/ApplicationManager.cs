using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace WebGbimTests
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        public string baseURL;
        private LoginHelper loginHelper;
        private NavigationHelper navigator;
        private ProjectHelper projectHelper;
        public WorkingGroupHelper workingGroupHelper;
        private HelperBase helperBase;
        private InitDataHelper initDataHelper;
        private DevelopTEOHelper developTEOHelper;



        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();
        //private ApplicationManager app;

        private ApplicationManager()
        {
            driver = new ChromeDriver();
            // driver = new FirefoxDriver();
            baseURL = "http://gbim-frontend.kz/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            driver.Navigate().GoToUrl(baseURL + "main/projects");
            driver.Manage().Window.Maximize();
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            projectHelper = new ProjectHelper(this);
            workingGroupHelper = new WorkingGroupHelper(this);
            helperBase = new HelperBase(this);
            initDataHelper = new InitDataHelper(this);
            developTEOHelper = new DevelopTEOHelper(this);
            // сделал упрощенный гет без поля если будут проблемы исправить 
            AppKVE = new AppKVECreateHelper(this);
            PackageKVE = new PackageKVECreateHelper(this);

        }
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Не сработал деструктор");
                // Ignore errors if unable to close the browser
            }
        }
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.OpenProjectPage();
                app.Value = newInstance;
            }
            return app.Value;

        }
        public LoginHelper Auth { get => loginHelper; }
        public NavigationHelper Navigator { get => navigator; }
        public ProjectHelper Projects { get => projectHelper; }
        public IWebDriver Driver { get => driver; }
        public WorkingGroupHelper WorkingGroupHelper { get => workingGroupHelper; }
        public HelperBase HelperBase { get => helperBase; }
        public InitDataHelper InitData { get => initDataHelper; }
        public DevelopTEOHelper DevelopTEO { get => developTEOHelper; }
        public AppKVECreateHelper AppKVE { get; }
        public PackageKVECreateHelper PackageKVE { get; }
        
    }   
}
