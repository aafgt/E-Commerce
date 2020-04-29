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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("userLogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string username = txt_username.Text;
            string password = txt_password.Text;

            //pass parameters to the stored procedure
            if (username == "" || password == "" || username == null || password == null)
            {
                Response.Write("Username or Password is missing");
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));

                //Save the output from the procedure
                SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = cmd.Parameters.Add("@type", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;
                //Executing the SQLCommand
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                if (success.Value.ToString().Equals("1"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("Passed");

                    /*ASP.NET session state enables you to store and retrieve values for a user
                    as the user navigates ASP.NET pages in a Web application.
                    This is how we store a value in the session*/
                    Session["field1"] = username;

                    //To navigate to another webpage
                    if (type.Value.ToString().Equals("0"))
                    {
                        Response.Redirect("CustomerPage.aspx", true);
                    }
                    if (type.Value.ToString().Equals("1"))
                    {
                        Response.Redirect("vendorPage.aspx", true);
                    }
                    if (type.Value.ToString().Equals("2"))
                    {
                        Response.Redirect("adminPage.aspx", true);
                    }

                }
                else
                {
                    Response.Write("Username or Password incorrect");
                }
            }
        }
    }
}