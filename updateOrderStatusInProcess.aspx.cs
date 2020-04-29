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
    public partial class updataOrderStatusInProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("updateOrderStatusInProcess", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string order_no = TextBox1.Text;

            if (order_no == "")
            {
                Response.Write("order number is missing");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("isOrder", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@order_no", order_no));
                SqlParameter success = cmd2.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("order does not exist");
                }
                else
                {
                    //pass parameters to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@order_no", order_no));

                    //Save the output from the procedure
                    //Executing the SQLCommand
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("order status updated to (in process)");
                }
            }
        }
    }
}