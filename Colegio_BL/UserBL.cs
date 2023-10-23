using Colegio_ADO;
using Colegio_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BL
{
    public class UserBL
    {
        UserADO objUserADO = new UserADO();

        public UserBE GetUserByID(String strLogin)
        {
            return objUserADO.GetUserByID(strLogin);
        }
    }
}
