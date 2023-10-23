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
    public class EnrollmentADO
    {

        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListEnrollments()
        {
            try
            {

            connection.ConnectionString = connectionADO.GetConnection();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_ListEnrollments";
            command.Parameters.Clear();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Enrollments");
            return dataSet.Tables["Enrollments"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EnrollmentBE GetEnrollmentByID(Int16 intID)
        {
            try
            {
                EnrollmentBE objEnrollmentBE = new EnrollmentBE();
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetEnrollmentByID";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@EnrollmentID", intID);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    dataReader.Read();
                    objEnrollmentBE.EnrollmentID = Convert.ToInt16(dataReader["EnrollmentID"]);
                    objEnrollmentBE.StudentID = Convert.ToInt16(dataReader["StudentID"]);
                    objEnrollmentBE.GradeID = Convert.ToInt16(dataReader["GradeID"]);
                    objEnrollmentBE.DateCreated = Convert.ToDateTime(dataReader["DateCreated"]);
                    objEnrollmentBE.PaymentStatus = Convert.ToInt16(dataReader["PaymentStatus"]);
                    objEnrollmentBE.RecepcionistId = Convert.ToInt16(dataReader["RecepcionistId"]);
                }
                dataReader.Close();
                return objEnrollmentBE;
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

        public Boolean InsertEnrollment(EnrollmentBE objEnrollmentBe)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertEnrollment";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@StudentID", objEnrollmentBe.StudentID);
                command.Parameters.AddWithValue("@GradeID", objEnrollmentBe.GradeID);
                command.Parameters.AddWithValue("@DateCreated", objEnrollmentBe.DateCreated);
                command.Parameters.AddWithValue("@PaymentStatus", objEnrollmentBe.PaymentStatus);
                command.Parameters.AddWithValue("@RecepcionistId", objEnrollmentBe.RecepcionistId);
                command.Parameters.AddWithValue("@RegisteringUser", objEnrollmentBe.RegisteringUser);

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

        public Boolean UpdateEnrollment(EnrollmentBE objEnrollmentBe)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_UpdateEnrollment";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@EnrollmentID", objEnrollmentBe.EnrollmentID);
                command.Parameters.AddWithValue("@StudentID", objEnrollmentBe.StudentID);
                command.Parameters.AddWithValue("@GradeID", objEnrollmentBe.GradeID);
                command.Parameters.AddWithValue("@DateCreated", objEnrollmentBe.DateCreated);
                command.Parameters.AddWithValue("@PaymentStatus", objEnrollmentBe.PaymentStatus);
                command.Parameters.AddWithValue("@RecepcionistId", objEnrollmentBe.RecepcionistId);
                command.Parameters.AddWithValue("@LastModifiedUser", objEnrollmentBe.LastModifiedUser);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
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

        public Boolean DeleteEnrollment(Int16 intID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_DeleteEnrollment";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@EnrollmentID", intID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
