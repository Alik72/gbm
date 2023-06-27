using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGbimTests;
using NUnit.Framework;

namespace WebGbimTests
{
    public class AuthTestBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            //Нечаев
            app.Auth.Login(new AccountDate("AUTH_RSA256_ffd3771ab1bd0de176deca52dbe546b342cec604.p12", "nii123"), "Открыть файл");
            //Азиза
            //app.Auth.Login(new AccountDate("AUTH_RSA256_f7f812cf2d74093e4c6555bf830b30a44bbb205b.p12","Qwerty12*"), "Открыть файл");
        }
    }
}
