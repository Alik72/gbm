using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class AccountDate
    {
        public AccountDate(String userezp, String password)
        {
            Userezp = userezp;
            Password = password;
        }
        public string Userezp { get; set; }
        public string Password { get; set; }
    }
}
