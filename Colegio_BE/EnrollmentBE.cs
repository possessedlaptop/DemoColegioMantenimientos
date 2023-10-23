using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class EnrollmentBE
    {
        public Int16 EnrollmentID { get; set; }
        public Int16 StudentID { get; set; }
        public Int16 GradeID { get; set; }
        public DateTime DateCreated { get; set; }
        public Int16 PaymentStatus { get; set; }
        public Int16 RecepcionistId { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public String LastModifiedUser { get; set; }
    }
}
