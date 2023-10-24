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
    public class RecepcionistBL
    {

        RecepcionistADO RecepcionistADO = new RecepcionistADO();

        public DataTable ListRecepcionists()
        {
            return RecepcionistADO.ListRecepcionists();
        }

        public Boolean InsertRecepcionist(RecepcionistBE objRecepcionist)
        {
            return RecepcionistADO.InsertRecepcionist(objRecepcionist);
        }

        public Boolean UpdateRecepcionist(RecepcionistBE objRecepcionist)
        {
            return RecepcionistADO.UpdateRecepcionist(objRecepcionist);
        }

        public Boolean DeleteRecepcionist(Int16 intID)
        {
            return RecepcionistADO.DeleteRecepcionist(intID);
        }

        public RecepcionistBE GetRecepcionistByID(Int16 intID)
        {
            return RecepcionistADO.GetRecepcionistByID(intID);
        }
    }
}
