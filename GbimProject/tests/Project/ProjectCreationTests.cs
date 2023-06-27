using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools;
using WindowsInput;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.IO;
using OpenQA.Selenium.Interactions;


namespace WebGbimTests
{
    [TestFixture]
    public class ProectCreationTests : AuthTestBase

    {
    [Test]
    public void ProectCreationTest()
        {
            app.Navigator.GoToTypeCustomer()
                         .OpenProjectPage();
            int oldNumberCreatedProjects = app.HelperBase.CountCreatedProjects(10000);
            ProjectDate project = new ProjectDate(
                "a-1", "наимен рус", "наимен каз", "наимен анг", "крат опис рус", "крат опис kaz", 
                "крат опис eng", "дет опис rus", "дет опис каз", "дет опис eng", 
                "Негосударственные инвестиции", "Модернизация", "Детский сад на 100 мест");
            app.Projects.Create(project);
            app.Navigator.OpenProjectPage();
            int newNumberCreatedProjects = app.HelperBase.CountCreatedProjects(10000);
            Assert.That(newNumberCreatedProjects, Is.EqualTo(oldNumberCreatedProjects + 1));

        }

        
}
}

