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
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void SpecifyAmount(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("SpecifyAmount", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            String username = Session["field1"].ToString();
            int orderID = -1;
            decimal cash = 0;
            decimal credit = 0;
            if (txt_cash.Text.Equals("") || txt_cash.Text == null)
            {
                cash = 0;
            }
            else
            {
                cash = decimal.Parse(txt_cash.Text);
            }

            if (txt_credit.Text.Equals("") || txt_credit.Text == null)
            {
                credit = 0;
            }
            else
            {
                credit = decimal.Parse(txt_credit.Text);
            }

            if (txt_orderID.Text.Equals(""))
            {
                orderID = -1;
            }
            else
            {
                orderID = int.Parse(txt_orderID.Text);
            }

            //pass parameters to the stored procedure

            cmd.Parameters.Add(new SqlParameter("@customername", username));
            cmd.Parameters.Add(new SqlParameter("@orderID", orderID));
            cmd.Parameters.Add(new SqlParameter("@cash", cash));
            cmd.Parameters.Add(new SqlParameter("@credit", credit));

            //Save the output from the procedure
            SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;


            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString().Equals("1"))
            {
                Response.Write("Passed");

            }
            else if (success.Value.ToString().Equals("0"))
            {
                Response.Write("No Cash or Credit Amount Has Been Entered");
            }
            else if (success.Value.ToString().Equals("3"))
            {
                Response.Write("No Order ID Entered");
            }
            else if (success.Value.ToString().Equals("2"))
            {
                Response.Write("Incorrect Order ID Entered");
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("customerPage.aspx", true);
        }
    }
}