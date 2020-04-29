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
    public partial class removefromwishlistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void removeFromWishlist(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("removefromWishlist", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string wishlist = txt_wishlist_name.Text;
            string serial = txt_serial_no.Text;
            string username = (string)(Session["field1"]);
            
                //pass parameters to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@customername", username));
                cmd.Parameters.Add(new SqlParameter("@wishlistname", wishlist));
                cmd.Parameters.Add(new SqlParameter("@serial_no", serial));
                SqlParameter success = cmd.Parameters.Add("@BIT", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
            //Save the output from the procedure
            //Executing the SQLCommand
            if (wishlist == "" || wishlist == null || serial == "" || serial == null)
            {
                Response.Write("Wishlist Name or Serial Number is Missing");
            }
            else {
                
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("Product does not exsist in the Wishlist");
                }
                else
                {
                    Response.Write("Product is Removed");
                }
            }
        }
    

    }
}