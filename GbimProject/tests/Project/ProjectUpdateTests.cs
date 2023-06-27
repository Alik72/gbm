using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;


namespace WebGbimTests
{
    public class ProjectUpdateTests: AuthTestBase
    {
        [Test]
        public void ProectUpdateTest()
        {
            app.Navigator.GoToTypeCustomer()
                         .OpenProjectPage()
                         .GoToOneProject();
            app.Projects.InitProjectUpdate()
                         .FillProjectForm(new ProjectDate("a-126", "наимен рус", "наимен каз", "наимен анг", "крат опис рус", "крат опис kaz", "крат опис eng", "дет опис rus", "дет опис каз", "дет опис eng", "Негосударственные инвестиции", "Модернизация", "Детский сад на 100 мест"))
                         .SubmitProjectСreation();
        }

        
    }
}
