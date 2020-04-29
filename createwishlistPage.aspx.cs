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
    public partial class createwishlistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void Create(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("createWishlist", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string wishname = Wishname.Text;

            string username = (string)(Session["field1"]);
            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@customername", username));
            cmd.Parameters.Add(new SqlParameter("@name", wishname));

            //Save the output from the procedure
            //Executing the SQLCommand
            
                if (wishname == null || wishname == "")
                {
                    Response.Write("Please enter a Wishlist Name");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("Wishlist is Added");
                    }
                    catch (Exception x)
                    {
                        if (x.Message.Contains("duplicate"))
                            Response.Write("This Wishlist is already Added");
                    }
                }
            
        }
    }
}
