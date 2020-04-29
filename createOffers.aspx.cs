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
    public partial class createOffers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void createOffer(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addOffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                int offeramount = int.Parse(TextBox1.Text);
                string expiry_date = Date.Text;

                DateTime expiryDate = Convert.ToDateTime(expiry_date);
                cmd.Parameters.Add(new SqlParameter("@offeramount", offeramount));
                cmd.Parameters.Add(new SqlParameter("@expiry_date", expiryDate));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("Created!");
            }

            catch (FormatException)
            {
                Response.Write("Some of the boxes are missing or the format of one of the boxes is incorrect!");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["field1"] = "";
            Response.Redirect("Login.aspx", true);
        }
    }
}