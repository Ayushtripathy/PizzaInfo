using PizzaInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PizzaInfo.Data_Access_Layer
{
    public class CustomerTableDB
    {
        readonly string connStr = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=CommonSimulation1;Integrated Security=True";
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataReader = null;
        public int InsertCustomer(CustomerModel customerModel)
        {
            try
            {
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
                string query = "insert into Customer values(@fnm,@lnm,@add)";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@fnm", customerModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@lnm", customerModel.LastName);
                sqlCommand.Parameters.AddWithValue("@add", customerModel.Address);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                sqlConnection.Close();
            }
            return 0;
        }
        public List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customerList= new List<CustomerModel>();
            try
            {
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Select * from Customer", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    CustomerModel customerModel = new CustomerModel
                    {
                        CustomerId = int.Parse(sqlDataReader[0].ToString()),
                        FirstName = sqlDataReader[1].ToString(),
                        LastName = sqlDataReader[2].ToString(),
                        Address = sqlDataReader[3].ToString()
                    };
                    customerList.Add(customerModel);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                sqlConnection.Close();
            }
            return customerList;
        }
    }
}