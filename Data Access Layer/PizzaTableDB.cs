using PizzaInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PizzaInfo.Data_Access_Layer
{
    public class PizzaTableDB
    {
        readonly string connStr = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=CommonSimulation1;Integrated Security=True";
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataReader = null;
        public int InsertPizza(PizzaModel pizzaModel)
        {
            try
            {
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
                string query = "insert into Pizza values(@phn,@top,@spec,@date,@size,@del)";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@phn", pizzaModel.PhoneNum);
                sqlCommand.Parameters.AddWithValue("@top", pizzaModel.Toppings);
                sqlCommand.Parameters.AddWithValue("@spec", pizzaModel.SpecialInfo);
                sqlCommand.Parameters.AddWithValue("@date", pizzaModel.OrderDate);
                sqlCommand.Parameters.AddWithValue("@size", pizzaModel.Size);
                sqlCommand.Parameters.AddWithValue("@del", pizzaModel.Deliver == true ? "Yes" : "No");
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
        public List<PizzaModel> GetPizzas()
        {
            List<PizzaModel> pizzaList = new List<PizzaModel>();
            try
            {
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Select * from Pizza", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    PizzaModel pizzaModel = new PizzaModel
                    {
                        OrderId = int.Parse(sqlDataReader[0].ToString()),
                        PhoneNum = sqlDataReader[1].ToString(),
                        Toppings = sqlDataReader[2].ToString(),
                        SpecialInfo = sqlDataReader[3].ToString(),
                        OrderDate = DateTime.Parse(sqlDataReader[4].ToString()),
                        Size = sqlDataReader[5].ToString(),
                        Deliver = sqlDataReader[6].ToString() == "Yes"
                    };
                    pizzaList.Add(pizzaModel);
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
            finally
            {
                sqlConnection.Close();
            }
            return pizzaList;
        }
    }
}