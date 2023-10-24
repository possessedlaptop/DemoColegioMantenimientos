using Colegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BL
{
    public class ClassroomBL
    {

        ClassroomADO objClassroomADO = new ClassroomADO();

        public DataTable ListClassrooms()
        {
            return objClassroomADO.ListClassrooms();
        }

    }
}
