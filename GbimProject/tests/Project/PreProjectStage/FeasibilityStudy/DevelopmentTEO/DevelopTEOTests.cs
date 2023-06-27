using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    [TestFixture]
    public class DevelopTEOTests : AuthTestBase

    {
        [Test]
        public void TestDevelopTEOCreateDocumentation()
        {
            app.Navigator
                .GoToPreProjectStageTEO()
                .GoToTabDevelopmentTEO();
            app.DevelopTEO
                .Сreation()
                .FillDevelopTEOForm()
                .Submit();
            Assert.True(app.HelperBase.PresentDocumentSection());

            app.HelperBase.AgreementProcess
                (new AccountDate("GOSTKNCA_a2c3657fba15406947f99021f5bcbf2c07211e31.p12", "nii123")
                , "Открыть файл");
            app.HelperBase
                .CompleteFormation()
                .ApplyForKVE();
            
        }
    }
    
}
