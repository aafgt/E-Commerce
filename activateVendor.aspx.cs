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
    public partial class activateVendor : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("activateVendors", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string vendor_username = TextBox2_vendor.Text;

            string username = (string)(Session["field1"]);

            if (vendor_username == "")
            {
                Response.Write("vendor username is missing");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("isAdminVendor", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@admin_username", username));
                cmd2.Parameters.Add(new SqlParameter("@vendor_username", vendor_username));
                SqlParameter success = cmd2.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("This vendor username does not exist");
                }
                else
                {
                    //pass parameters to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@admin_username", username));
                    cmd.Parameters.Add(new SqlParameter("@vendor_username", vendor_username));

                    //Save the output from the procedure
                    //Executing the SQLCommand
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Vendor is activated");
                }
            }
        }
    }
}