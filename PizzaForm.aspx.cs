using PizzaInfo.Data_Access_Layer;
using PizzaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaInfo
{
    public partial class PizzaForm : System.Web.UI.Page
    {
        readonly PizzaModel pizzaModel = new PizzaModel();
        readonly PizzaTableDB pizzaTableDB = new PizzaTableDB();
        readonly CustomerModel customerModel = new CustomerModel();
        readonly CustomerTableDB customerTableDB = new CustomerTableDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            tbdate.Text = DateTime.Now.Date.Date.ToString();
        }
        protected void btnbuild_Click(object sender, EventArgs e)
        {
            pizzaModel.OrderDate = DateTime.Parse(tbdate.Text);
            pizzaModel.PhoneNum = tbphone.Text;
            pizzaModel.Size = rbsize.SelectedValue;
            pizzaModel.Deliver = cbdeliver.Checked;
            pizzaModel.SpecialInfo = tbspecial.Text;
            pizzaModel.Toppings = "";
            foreach(ListItem temp in cbtoppings.Items)
            {
                if (temp.Selected)
                {
                    pizzaModel.Toppings += temp.Text + " ";
                }
            }
            customerModel.FirstName = tbfirst.Text;
            customerModel.LastName = tblast.Text;
            customerModel.Address = tbaddr.Text;
            try
            {
                if (pizzaTableDB.InsertPizza(pizzaModel) > 0)
                    output.Text = "Data inserted in Pizza successfully";
                else
                    output.Text = "Displaying default text";
            }
            catch(Exception ex)
            {
                output.Text = ex.Message;
            }
            try
            {
                if (customerTableDB.InsertCustomer(customerModel) > 0)
                    output.Text += "\nData inserted in Customer successfully";
                else
                    output.Text += "\nDisplaying default text";
            }
            catch(Exception ex)
            {
                output.Text += ex.Message;
            }
        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = pizzaTableDB.GetPizzas();
            GridView1.DataBind();
            GridView2.DataSource = customerTableDB.GetCustomers();
            GridView2.DataBind();
        }
    }
}