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
    public class TeacherBL
    {
        TeacherADO objTeacherADO = new TeacherADO();

        public DataTable ListTeachers()
        {
            return objTeacherADO.ListTeachers();
        }

        public Boolean InsertTeacher(TeacherBE objTeacher)
        {
            return objTeacherADO.InsertTeacher(objTeacher);
        }

        public Boolean UpdateTeacher(TeacherBE objTeacher)
        {
            return objTeacherADO.UpdateTeacher(objTeacher);
        }

        public Boolean DeleteTeacher(Int16 intID)
        {
            return objTeacherADO.DeleteTeacher(intID);
        }

        public TeacherBE GetTeacherByID(Int16 intID)
        {
            return objTeacherADO.GetTeacherByID(intID);
        }

    }
}
