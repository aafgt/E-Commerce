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
    public partial class CancellingOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void CancelOrders(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("cancelOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            int orderID = -1;

            if (txt_order.Text.Equals(""))
            {
                orderID = -1;
            }
            else
            {
                orderID = int.Parse(txt_order.Text);
            }

            //pass parameters to the stored procedure

            cmd.Parameters.Add(new SqlParameter("@orderID", orderID));

            //Save the output from the procedure
            SqlParameter success = cmd.Parameters.Add("@check", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;


            //Executing the SQLCommand
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString().Equals("1"))
            {
                Response.Write("Order Canceled");

            }
            else if (success.Value.ToString().Equals("0"))
            {
                Response.Write("Cannot Cancel Order as the status is not 'not processed' or 'in process'");
            }
            else if (success.Value.ToString().Equals("2"))
            {
                Response.Write("No Order ID Entered");
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("customerPage.aspx", true);
        }
    }
}