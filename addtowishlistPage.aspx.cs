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
    public partial class addtowishlistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void AddToWishlist(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("AddtoWishlist", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string wishlist = txt_wishlist_add.Text;
            string serial = txt_serial_add.Text;
            string username = (string)(Session["field1"]);
            
                //pass parameters to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@customername", username));
                cmd.Parameters.Add(new SqlParameter("@wishlistname", wishlist));
                cmd.Parameters.Add(new SqlParameter("@serial_no", serial));

            //Save the output from the procedure
            //Executing the SQLCommand
            if (wishlist == "" || wishlist == null || serial == "" || serial == null)
            {
                Response.Write("Wishlist Name or Product Serial Number is Missing");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Product is Added");
                }
                catch (Exception x)
                {
                    if (x.Message.Contains("duplicate"))
                        Response.Write("This Product is already Added");
                    if (x.Message.Contains("serial_no"))
                        Response.Write("This Product's Serial Number is not Valid");
                    if (x.Message.Contains("wishlist"))
                        Response.Write("This Wishlist is not Valid");
                }

            }            
        }
    }
}