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
    public class TeacherADO
    {
        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListTeachers()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListTeachers";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Teachers");
                return dataSet.Tables["Teachers"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TeacherBE GetTeacherByID(Int16 intID)
        {
            try
            {
                TeacherBE objTeacherBE = new TeacherBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetTeacherByID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@TeacherID", intID);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objTeacherBE.TeacherID = Convert.ToInt16(dataReader["TeacherID"]);
                    objTeacherBE.StaffID = Convert.ToInt16(dataReader["StaffID"]);
                    objTeacherBE.SubjectTaught = Convert.ToInt16(dataReader["SubjectTaught"]);
                    objTeacherBE.Qualifications = dataReader["Qualifications"].ToString();


                }
                dataReader.Close();
                return objTeacherBE;

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

        public Boolean InsertTeacher(TeacherBE objTeacherBe)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertTeacher";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StaffID", objTeacherBe.StaffID);
                command.Parameters.AddWithValue("@SubjectTaught", objTeacherBe.SubjectTaught);
                command.Parameters.AddWithValue("@Qualifications", objTeacherBe.Qualifications);
                command.Parameters.AddWithValue("@RegisteringUser", objTeacherBe.RegisteringUser);

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

        public Boolean DeleteTeacher(Int16 intID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_DeleteTeacher";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@TeacherID", intID);

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

        public Boolean UpdateTeacher(TeacherBE objTeacherBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_UpdateTeacher";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@TeacherID", objTeacherBE.TeacherID);
                command.Parameters.AddWithValue("@StaffID", objTeacherBE.StaffID);
                command.Parameters.AddWithValue("@SubjectTaught", objTeacherBE.SubjectTaught);
                command.Parameters.AddWithValue("@Qualifications", objTeacherBE.Qualifications);
                command.Parameters.AddWithValue("@LastModifiedUser", objTeacherBE.LastModifiedUser);

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
