using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class RecepcionistBE
    {
        public Int16 RecepcionistId { get; set; }
        public Int16 StaffId { get; set; }
        public Int16 Shift { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public String LastModifiedUser { get; set; }
    }
}
