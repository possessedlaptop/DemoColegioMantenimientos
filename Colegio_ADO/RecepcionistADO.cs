using Colegio_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class RecepcionistADO
    {

        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListRecepcionists()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListRecepcionists";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Recepcionists");
                return dataSet.Tables["Recepcionists"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RecepcionistBE GetRecepcionistByID(Int16 intID)
        {
            try
            {
                RecepcionistBE objRecepcionistBE = new RecepcionistBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetRecepcionistByID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@RecepcionistID", intID);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objRecepcionistBE.RecepcionistId = Convert.ToInt16(dataReader["RecepcionistID"]);
                    objRecepcionistBE.StaffId = Convert.ToInt16(dataReader["StaffID"]);
                    objRecepcionistBE.Shift = Convert.ToInt16(dataReader["Shift"]);
                }
                dataReader.Close();
                return objRecepcionistBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public Boolean InsertRecepcionist(RecepcionistBE objRecepcionistBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertRecepcionist";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StaffID", objRecepcionistBE.StaffId);
                command.Parameters.AddWithValue("@Shift", objRecepcionistBE.Shift);
                command.Parameters.AddWithValue("@RegisteringUser", objRecepcionistBE.RegisteringUser);

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Boolean DeleteRecepcionist(Int16 intID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_DeleteRecepcionist";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@RecepcionistID", intID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Boolean UpdateRecepcionist(RecepcionistBE objRecepcionistBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_UpdateRecepcionist";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@RecepcionistID", objRecepcionistBE.RecepcionistId);
                command.Parameters.AddWithValue("@StaffID", objRecepcionistBE.StaffId);
                command.Parameters.AddWithValue("@Shift", objRecepcionistBE.Shift);
                command.Parameters.AddWithValue("@LastModifiedUser", objRecepcionistBE.LastModifiedUser);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }


        }
    }
}
