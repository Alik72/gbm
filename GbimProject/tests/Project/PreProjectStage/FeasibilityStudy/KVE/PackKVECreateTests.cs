using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    [TestFixture]
    public class PackKVECreateTests : AuthTestBase

    {
        [Test]
        public void PackKVECreateTest() 
        {
            app.Navigator
                .GoToPreProjectStageTEO()
                .GoToTabKVE()
                .GoToOneApplicKVE();
           
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
