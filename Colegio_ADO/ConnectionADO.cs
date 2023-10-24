using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class ConnectionADO
    {
        public string GetConnection()
        {
            string connection = 
                ConfigurationManager.ConnectionStrings["Colegio"].ConnectionString;
            if(object.ReferenceEquals(connection, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return connection;
            }
        }
    }
}
