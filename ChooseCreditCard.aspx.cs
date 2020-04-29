using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class ChooseCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string username1 = (string)(Session["field1"]);
            if (username1 == "" || username1 == null)
            {
                Response.Redirect("Login.aspx", true);
            }
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("ViewMyCreditCard", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            String username = Session["field1"].ToString();
            cmd.Parameters.Add(new SqlParameter("@customername", username));

            if (!IsPostBack)
            {
                CreditCardNumbers.Items.Clear();

                CreditCardNumbers.Items.Add(new
                        ListItem("Select A CreditCard", "-1"));

                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CreditCardNumbers.Items.Add(new
                        ListItem(dr[0].ToString(), dr[0].ToString()));
                }
                conn.Close();
            }
        }
        protected void ChoosingCreditCard(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("ChooseCreditCard", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            int orderID = -1;

            string creditcard = CreditCardNumbers.SelectedValue;

            if (txt_orderID.Text.Equals(""))
            {
                orderID = -1;
            }
            else
            {
                orderID = int.Parse(txt_orderID.Text);
            }

            if (creditcard.Equals("-1"))
            {
                Response.Write("Please Select A CreditCard Number");
            }

            else
            {
                //pass parameters to the stored procedure

                cmd.Parameters.Add(new SqlParameter("@creditcard", creditcard));
                cmd.Parameters.Add(new SqlParameter("@orderID", orderID));

                //Save the output from the procedure
                SqlParameter check = cmd.Parameters.Add("@check", SqlDbType.Int);
                check.Direction = ParameterDirection.Output;


                //Executing the SQLCommand
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (check.Value.ToString().Equals("1"))
                {
                    Response.Write("Credit Card Has Been Chosen Successfully");

                }
                else if (check.Value.ToString().Equals("0"))
                {
                    Response.Write("OrderID Not Found");
                }
                else if (check.Value.ToString().Equals("2"))
                {
                    Response.Write("CreditCard Number Not Found");
                }
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("customerPage.aspx", true);
        }
    }
}