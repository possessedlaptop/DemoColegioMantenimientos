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
    public class EnrollmentBL
    {

        EnrollmentADO enrollmentADO = new EnrollmentADO();

        public DataTable ListEnrollments()
        {
            return enrollmentADO.ListEnrollments();
        }

        public Boolean InsertEnrollment(EnrollmentBE objEnrollment)
        {
            return enrollmentADO.InsertEnrollment(objEnrollment);
        }

        public Boolean UpdateEnrollment(EnrollmentBE objEnrollment)
        {
            return enrollmentADO.UpdateEnrollment(objEnrollment);
        }

        public Boolean DeleteEnrollment(Int16 intID)
        {
            return enrollmentADO.DeleteEnrollment(intID);
        }

        public EnrollmentBE GetEnrollmentByID(Int16 intID)
        {
            return enrollmentADO.GetEnrollmentByID(intID);
        }

    }
}
