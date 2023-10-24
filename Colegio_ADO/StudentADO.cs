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
    public class StudentADO
    {
        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListStudents()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListStudents";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Students");
                return dataSet.Tables["Students"];
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public StudentBE GetStudentByID(Int16 intID)
        {
            try
            {
                StudentBE objStudentBE = new StudentBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetStudentByID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StudentID", intID);

                connection.Open();
                dataReader = command.ExecuteReader();

                if(dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objStudentBE.StudentID = Convert.ToInt16(dataReader["StudentID"]);
                    objStudentBE.FirstName = dataReader["FirstName"].ToString();
                    objStudentBE.SecondName = dataReader["SecondName"].ToString();
                    objStudentBE.FirstLastName = dataReader["FirstLastName"].ToString();
                    objStudentBE.SecondLastName = dataReader["SecondLastName"].ToString();
                    objStudentBE.DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"]);
                    objStudentBE.Gender = Convert.ToInt16(dataReader["Gender"]);
                    objStudentBE.Address = dataReader["Adress"].ToString();
                    objStudentBE.ID_Ubigeo = dataReader["ID_Ubigeo"].ToString();
                    objStudentBE.ContactMail = dataReader["ContactMail"].ToString();
                    objStudentBE.DNI_Number = dataReader["DNI_Number"].ToString();
                    // Veamos si la foto funciona, si no, lo haremos por url a una ubicacion en disco
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("StudentPhoto")))
                    {
                    objStudentBE.StudentPhoto = (Byte[])(dataReader["StudentPhoto"]);
                    }
                    else
                    {
                        objStudentBE.StudentPhoto = null;
                    }
                    objStudentBE.CurrentState = Convert.ToInt16(dataReader["CurrentState"]);
                    objStudentBE.ClassroomId = Convert.ToInt16(dataReader["ClassroomId"]);
              
                }
                dataReader.Close();
                return objStudentBE;

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

        public Boolean InsertStudent(StudentBE objStudentBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertStudent";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@FirstName", objStudentBE.FirstName);
                command.Parameters.AddWithValue("@SecondName", objStudentBE.SecondName);
                command.Parameters.AddWithValue("@FirstLastName", objStudentBE.FirstLastName);
                command.Parameters.AddWithValue("@SecondLastName", objStudentBE.SecondLastName);
                command.Parameters.AddWithValue("@DateOfBirth", objStudentBE.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", objStudentBE.Gender);
                command.Parameters.AddWithValue("@Adress", objStudentBE.Address);
                command.Parameters.AddWithValue("@ID_Ubigeo", objStudentBE.ID_Ubigeo);
                command.Parameters.AddWithValue("@ContactMail", objStudentBE.ContactMail);
                command.Parameters.AddWithValue("@DNI_Number", objStudentBE.DNI_Number);
                command.Parameters.AddWithValue("@StudentPhoto", objStudentBE.StudentPhoto);
                command.Parameters.AddWithValue("@CurrentState", objStudentBE.CurrentState);
                command.Parameters.AddWithValue("@ClassroomId", objStudentBE.ClassroomId);
                command.Parameters.AddWithValue("@RegisteringUser", objStudentBE.RegisteringUser);

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

        public Boolean DeleteStudent(Int16 intID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_DeleteStudent";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StudentID", intID);

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

        public Boolean UpdateStudent(StudentBE objStudentBE)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_UpdateStudent";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StudentID", objStudentBE.StudentID);
                command.Parameters.AddWithValue("@FirstName", objStudentBE.FirstName);
                command.Parameters.AddWithValue("@SecondName", objStudentBE.SecondName);
                command.Parameters.AddWithValue("@FirstLastName", objStudentBE.FirstLastName);
                command.Parameters.AddWithValue("@SecondLastName", objStudentBE.SecondLastName);
                command.Parameters.AddWithValue("@DateOfBirth", objStudentBE.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", objStudentBE.Gender);
                command.Parameters.AddWithValue("@Adress", objStudentBE.Address);
                command.Parameters.AddWithValue("@ID_Ubigeo", objStudentBE.ID_Ubigeo);
                command.Parameters.AddWithValue("@ContactMail", objStudentBE.ContactMail);
                command.Parameters.AddWithValue("@DNI_Number", objStudentBE.DNI_Number);
                command.Parameters.AddWithValue("@StudentPhoto", objStudentBE.StudentPhoto);
                command.Parameters.AddWithValue("@CurrentState", objStudentBE.CurrentState);
                command.Parameters.AddWithValue("@ClassroomId", objStudentBE.ClassroomId);
                command.Parameters.AddWithValue("@LastModifiedUser", objStudentBE.LastModifiedUser);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(SqlException ex)
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
