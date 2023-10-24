using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class StaffBE
    {
        public Int16 StaffID { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String FirstLastName { get; set; }
        public String SecondLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime OnBoardingStart { get; set; }
        public String Address { get; set; }
        public String ID_Ubigeo { get; set; }
        public Int16 IntRole { get; set; }
        public String ContactMail { get; set; }
        public String ContactNumber { get; set; }
        public Byte[] StaffPhoto { get; set; }
        public Int16 CurrentState { get; set; }
        // public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public String LastModifiedUser { get; set; }
    }
}
