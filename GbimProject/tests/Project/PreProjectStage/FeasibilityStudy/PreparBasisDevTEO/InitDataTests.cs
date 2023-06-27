using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    [TestFixture]
    public class InitDataTests : AuthTestBase

    {
        [Test]
        public void TestInitData()
        {
            app.Navigator
                .GoToPreProjectStageTEO()
                .GoToTabPreparBasisDevTEO()
                .GoToTabInitData();
            app.InitData
                .InitСreation()
                .FillInitDataForm()
                .SubmitEndRefresh();
            Assert.True(app.HelperBase.PresentDocumentSection());
        }
    }
}
