using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    [TestFixture]
    public class AppKVECreateTests : AuthTestBase

    {
        [Test]
        public void AppKVECreateTest()
        {
            app.Navigator
                .GoToPreProjectStageTEO()
                .GoToTabKVE();
            app.AppKVE
                .InСreation()
                .FillAppKVEForm()
                .SubmitAppKVE();
        

        }
    }
}
