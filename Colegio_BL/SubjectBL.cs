using Colegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BL
{
    public class SubjectBL
    {

        SubjectADO objSubjectADO = new SubjectADO();

        public DataTable ListSubjects()
        {
            return objSubjectADO.ListSubjects();
        }

    }
}
