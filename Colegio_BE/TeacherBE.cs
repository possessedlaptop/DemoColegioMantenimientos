using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class TeacherBE
    {
        public Int16 TeacherID { get; set; }
        public Int16 StaffID { get; set; }
        public Int16 SubjectTaught { get; set; }
        public String Qualifications { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public String LastModifiedUser { get; set; }
    }
}
