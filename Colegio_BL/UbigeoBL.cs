using Colegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BL
{
    public class UbigeoBL
    {

        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable ListDepartments()
        {
            return objUbigeoADO.ListDepartments();
        }

        public DataTable ListProvinces()
        {
            return objUbigeoADO.ListProvinces();
        }

        public DataTable ListDistricts()
        {
            return objUbigeoADO.ListDistricts();
        }

        public DataTable GetProvincesByDepartment(Int16 intID)
        {
            return objUbigeoADO.GetProvinceByDepartment(intID);
        }

        public DataTable GetDistrictsByDepartmentAndProvince(Int16 intDepartID, Int16 intProvID)
        {
            return objUbigeoADO.GetDistrictByDeparmentAndProvince(intDepartID, intProvID);
        }

    }
}
