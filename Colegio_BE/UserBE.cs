using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class UserBE
    {

        // Properties of the Entity User
        public String Login_User { get; set; }
        public String Login_Password { get; set; }
        public Int16 Login_Level { get; set; }
        public Int16 Login_State { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }

    }
}
