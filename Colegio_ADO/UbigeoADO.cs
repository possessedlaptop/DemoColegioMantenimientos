using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_ADO
{
    public class UbigeoADO
    {
        ConnectionADO connectionADO = new ConnectionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListDepartments()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListDepartments";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Departments");
                return dataSet.Tables["Departments"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListProvinces()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListProvinces";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Provinces");
                return dataSet.Tables["Provinces"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListDistricts()
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListDistricts";
                command.Parameters.Clear();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Districts");
                return dataSet.Tables["Districts"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetProvinceByDepartment(Int16 intDepartmentID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetProvinceByDepartment";
                command.Parameters.Clear();
                connection.Open();

                command.Parameters.AddWithValue("@intId", intDepartmentID);
                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Provinces");
                return dataSet.Tables["Provinces"];

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

        public DataTable GetDistrictByDeparmentAndProvince(Int16 intDepartmentID, Int16 intProvinceID)
        {
            try
            {
                connection.ConnectionString = connectionADO.GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_GetDistrictByDepartmentAndProvince";
                command.Parameters.Clear();
                connection.Open();

                command.Parameters.AddWithValue("@intDepartId", intDepartmentID);
                command.Parameters.AddWithValue("@intProvId", intProvinceID);
                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Districts");
                return dataSet.Tables["Districts"];
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
