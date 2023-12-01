using Colegio_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class UserADO
    {

        ConnectionADO con = new ConnectionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader sqlDataReader;

        public UserBE GetUserByID(String strLogin)
        {
            UserBE objUserBE = new UserBE();
            sqlConnection.ConnectionString = con.GetConnection();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "usp_GetUserByID";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Login_User", strLogin);
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows == true)
                {
                    sqlDataReader.Read();
                    objUserBE.Login_User = sqlDataReader["Login_User"].ToString();
                    objUserBE.Login_Password = sqlDataReader["Login_Password"].ToString();
                    objUserBE.Login_Level = Convert.ToInt16(sqlDataReader["Login_Level"]);
                    objUserBE.Login_State = Convert.ToInt16(sqlDataReader["Login_State"]);
                    objUserBE.RegisteringDate = Convert.ToDateTime(sqlDataReader["RegisteringDate"]);
                    objUserBE.RegisteringUser = sqlDataReader["RegisteringUser"].ToString();
                }
                sqlDataReader.Close();
                return objUserBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
