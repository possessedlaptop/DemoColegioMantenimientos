using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class GradeADO
    {
        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public DataTable ListGrades()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListGrades";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Grades");
                return dataSet.Tables["Grades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
