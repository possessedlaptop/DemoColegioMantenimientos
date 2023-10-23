using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BE
{
    public class StudentBE
    {
        public Int16 StudentID { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String FirstLastName { get; set; }
        public String SecondLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Int16 Gender { get; set; }
        public String Address { get; set; }
        public String ID_Ubigeo { get; set; }
        public String ContactMail { get; set; }
        public String DNI_Number { get; set; }
        // Que dios nos ayude si la foto es muy pesada
        public Byte[] StudentPhoto { get; set; }
        public Int16 CurrentState { get; set; }
        public Int16 ClassroomId { get; set; }
        public DateTime RegisteringDate { get; set; }
        public String RegisteringUser { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public String LastModifiedUser { get; set; }

    }
}
