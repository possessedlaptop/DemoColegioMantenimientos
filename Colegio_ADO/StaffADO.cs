using Colegio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class StaffADO
    {

        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListStaff()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListStaff";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Staff");
                return dataSet.Tables["Staff"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public StaffBE GetStaffByID(Int16 intID)
        {
            try
            {
                StaffBE objStaffBE = new StaffBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetStaffByID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StaffID", intID);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objStaffBE.FirstName = dataReader["FirstName"].ToString();
                    objStaffBE.SecondName = dataReader["SecondName"].ToString();
                    objStaffBE.FirstLastName = dataReader["FirstLastName"].ToString();
                    objStaffBE.SecondLastName = dataReader["SecondLastName"].ToString();
                    objStaffBE.DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"]);
                    objStaffBE.OnBoardingStart = Convert.ToDateTime(dataReader["OnBoardingStart"]);
                    objStaffBE.Address = dataReader["Adress"].ToString();
                    objStaffBE.ID_Ubigeo = dataReader["ID_Ubigeo"].ToString();
                    objStaffBE.IntRole = Convert.ToInt16(dataReader["IntRole"]);
                    objStaffBE.ContactMail = dataReader["ContactMail"].ToString();
                    objStaffBE.ContactNumber = dataReader["ContactNumber"].ToString();
                    // Veamos si la foto funciona, si no, lo haremos por url a una ubicacion en disco
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("StaffPhoto")))
                    {
                        objStaffBE.StaffPhoto = (Byte[])(dataReader["StaffPhoto"]);
                    }
                    else
                    {
                        objStaffBE.StaffPhoto = null;
                    }
                    objStaffBE.CurrentState = Convert.ToInt16(dataReader["CurrentState"]);

                }
                dataReader.Close();
                return objStaffBE;

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

        public StaffBE GetLastStaffIDFromTeacher()
        {
            try
            {
                StaffBE objStaffBE = new StaffBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetLastStaffIDFromTeacher";
                command.Parameters.Clear();

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objStaffBE.StaffID = Convert.ToInt16(dataReader["StaffID"].ToString());

                }
                dataReader.Close();
                return objStaffBE;
            }
            catch(SqlException ex)
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

        public Boolean InsertStaff(StaffBE objStaffBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertStaff";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@FirstName", objStaffBE.FirstName);
                command.Parameters.AddWithValue("@SecondName", objStaffBE.SecondName);
                command.Parameters.AddWithValue("@FirstLastName", objStaffBE.FirstLastName);
                command.Parameters.AddWithValue("@SecondLastName", objStaffBE.SecondLastName);
                command.Parameters.AddWithValue("@DateOfBirth", objStaffBE.DateOfBirth);
                command.Parameters.AddWithValue("@OnBoardingStart", objStaffBE.OnBoardingStart);
                command.Parameters.AddWithValue("@Adress", objStaffBE.Address);
                command.Parameters.AddWithValue("@ID_Ubigeo", objStaffBE.ID_Ubigeo);
                command.Parameters.AddWithValue("@IntRole", objStaffBE.IntRole);
                command.Parameters.AddWithValue("@ContactMail", objStaffBE.ContactMail);
                command.Parameters.AddWithValue("@ContactNumber", objStaffBE.ContactNumber);
                command.Parameters.AddWithValue("@StaffPhoto", objStaffBE.StaffPhoto);
                command.Parameters.AddWithValue("@CurrentState", objStaffBE.CurrentState);
                command.Parameters.AddWithValue("@RegisteringUser", objStaffBE.RegisteringUser);


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

        public Boolean DeleteStaff(Int16 intID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_DeleteStaff";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StaffID", intID);

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

        public Boolean UpdateStaff(StaffBE objStaffBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_UpdateStaff";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StaffID", objStaffBE.StaffID);
                command.Parameters.AddWithValue("@FirstName", objStaffBE.FirstName);
                command.Parameters.AddWithValue("@SecondName", objStaffBE.SecondName);
                command.Parameters.AddWithValue("@FirstLastName", objStaffBE.FirstLastName);
                command.Parameters.AddWithValue("@SecondLastName", objStaffBE.SecondLastName);
                command.Parameters.AddWithValue("@DateOfBirth", objStaffBE.DateOfBirth);
                command.Parameters.AddWithValue("@OnBoardingStart", objStaffBE.OnBoardingStart);
                command.Parameters.AddWithValue("@Adress", objStaffBE.Address);
                command.Parameters.AddWithValue("@ID_Ubigeo", objStaffBE.ID_Ubigeo);
                command.Parameters.AddWithValue("@ContactMail", objStaffBE.ContactMail);
                command.Parameters.AddWithValue("@ContactNumber", objStaffBE.ContactNumber);
                command.Parameters.AddWithValue("@IntRole", objStaffBE.IntRole);
                command.Parameters.AddWithValue("@StaffPhoto", objStaffBE.StaffPhoto);
                command.Parameters.AddWithValue("@CurrentState", objStaffBE.CurrentState);
                command.Parameters.AddWithValue("@LastModifiedUser", objStaffBE.LastModifiedUser);

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
