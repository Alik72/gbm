using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class ChooseTests : TestBase

    {
        [Test]
        public void ChooseTest()
        {
            app.Navigator
                .GoToTypeCustomer()
                .GoToProjectPage()
                .GoToOneProject()
                .GoToPreProjectStage()
                .GoToTabTEO()
                .GoToTabWorkGroup();
            app.WorkingGroupHelper
                .InitChooset()
                .ChoosetСontractDevTEO()
                .SubmitСontractDevTEO()
                .InitPackageDocumentsTEO()
                .ChoosetPackageDocumentsTEO()
                .SubmitPackageDocumentsTEO();

            Thread.Sleep(25000);

        }
    }
}
