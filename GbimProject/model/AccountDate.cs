using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class AccountDate
    {
        public String userezp;
        public String password;

        public AccountDate(String userezp, String password)
        {
            this.userezp = userezp;
            this.password = password;
        }
        public string Userezp { get => userezp; set => userezp = value; }
        public string Password { get => password; set => password = value; }
    }
}
