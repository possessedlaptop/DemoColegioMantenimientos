using Colegio_ADO;
using Colegio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BL
{
    public class StudentBL
    {
        StudentADO objStudentADO = new StudentADO();

        public DataTable ListStudents()
        {
            return objStudentADO.ListStudents();
        }

        public StudentBE GetStudentByID(Int16 intID)
        {
            return objStudentADO.GetStudentByID(intID);
        }

        public Boolean InsertStudent(StudentBE objStudent)
        {
            return objStudentADO.InsertStudent(objStudent);
        }

        public Boolean UpdateStudent(StudentBE objStudent)
        {
            return objStudentADO.UpdateStudent(objStudent);
        }

        public Boolean DeleteStudent(Int16 intID)
        {
            return objStudentADO.DeleteStudent(intID);
        }
    }
}
