using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class GradeBE
    {
        public Int16 GradeID { get; set; }
        public String GradeName { get; set; }
        public Int16 IntLevel { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String LastModifiedUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
