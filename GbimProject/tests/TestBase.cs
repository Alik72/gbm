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
    public class TestBase
    {
        
        public ApplicationManager app;
        

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            
           app.Auth.Login(new AccountDate("AUTH_RSA256_ffd3771ab1bd0de176deca52dbe546b342cec604.p12", "nii123"));
            
        }

        [TearDown]
        public void TeardownTest()
        {
           app.Stop();
           
        }
        
    }
}
