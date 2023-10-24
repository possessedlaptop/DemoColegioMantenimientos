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
    public class StaffBL
    {
        StaffADO objStaffADO = new StaffADO();

        public DataTable ListStaff()
        {
            return objStaffADO.ListStaff();
        }

        public StaffBE GetStaffByID(Int16 intID)
        {
            return objStaffADO.GetStaffByID(intID);
        }

        public StaffBE GetLastStaffIDFromTeacher()
        {
            return objStaffADO.GetLastStaffIDFromTeacher();
        }

        public Boolean InsertStaff(StaffBE objStaff)
        {
            return objStaffADO.InsertStaff(objStaff);
        }

        public Boolean UpdateStaff(StaffBE objStaff)
        {
            return objStaffADO.UpdateStaff(objStaff);
        }

        public Boolean DeleteStaff(Int16 intID)
        {
            return objStaffADO.DeleteStaff(intID);
        }
    }
}
