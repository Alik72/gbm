using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    [TestFixture]
    public class ExpertiseTEOTests : AuthTestBase

    {
        [Test]
        public void ExpertiseTEOTest()
        {
            //app.Navigator.GoToPreProjectStageTEO();
            ProectCreationTest();
            ChooseTest();
            TestInitData();
            TestDevelopTEOCreateDocumentation();
            CreateAppKVETest();
            PackKVECreateTest();
        }


        private void ProectCreationTest()
        {
            app.Navigator.GoToTypeCustomer()
                         .OpenProjectPage();
            int oldNumberCreatedProjects = app.HelperBase.CountCreatedProjects(10000);
            ProjectDate project = new ProjectDate(
                "a-76", "наимен рус", "наимен каз", "наимен анг", "крат опис рус", "крат опис kaz",
                "крат опис eng", "дет опис rus", "дет опис каз", "дет опис eng",
                "Негосударственные инвестиции", "Модернизация", "Детский сад на 100 мест");
            app.Projects.Create(project);
            app.Navigator.OpenProjectPage();
            int newNumberCreatedProjects = app.HelperBase.CountCreatedProjects(10000);
            Assert.That(newNumberCreatedProjects, Is.EqualTo(oldNumberCreatedProjects + 1));

        }
        private void ChooseTest()
        {
            app.Navigator
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
        }
        private void TestInitData()
        {
            app.Navigator
                .GoToTabTEO()
                .GoToTabPreparBasisDevTEO()
                .GoToTabInitData();
            app.InitData
                .InitСreation()
                .FillInitDataForm()
                .SubmitEndRefresh();
            Assert.True(app.InitData.PresentDocumentSection());
        }
        private void TestDevelopTEOCreateDocumentation()
        {
            app.Navigator
                .GoToTabTEO()
                .GoToTabDevelopmentTEO();
            app.DevelopTEO
                .Сreation()
                .FillDevelopTEOForm()
                .Submit();
            app.HelperBase
                .AgreementProcess(new AccountDate("GOSTKNCA_a2c3657fba15406947f99021f5bcbf2c07211e31.p12", "nii123")
                                 , "Открыть файл");

            app.HelperBase
                .CompleteFormation()
                .ApplyForKVE();
        }
        private void CreateAppKVETest()
        {
            app.Navigator
                .GoToTabKVE();
            app.AppKVE
                .InСreation()
                .FillAppKVEForm()
                .SubmitAppKVE();
        }
        private void PackKVECreateTest()
        {
            //app.Navigator
                //.GoToTabKVE()
                //.GoToOneApplicKVE();

            app.Navigator
                .GoToTabPackageDocument();
            app.PackageKVE
                .InitСreation()
                .FillPackageKVEForm();

            //Перейти во вкладку Заявки на КВЭ
            app.Navigator
                .GoToTabApplicationKVE();
            //Отправить Заявку на рассмотрение КВЭ
            app.AppKVE
                .SubmitForReviewKVE();
            app.HelperBase
                .EZP(new AccountDate("GOSTKNCA_a2c3657fba15406947f99021f5bcbf2c07211e31.p12", "nii123")
                                 , "Открыть файл");


        }
    }
}
