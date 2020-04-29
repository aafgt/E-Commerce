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
    public partial class removeEpiredOffers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void removeExpiredOffer(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("checkandremoveExpiredoffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                string vendor = Session["field1"].ToString();
                int offer_id = int.Parse(TextBox1.Text);

                //cmd.Parameters.Add(new SqlParameter("@vendorname", vendor));
                cmd.Parameters.Add(new SqlParameter("@offerid", offer_id));

                SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("1"))
                    Response.Write("Removed!");

                else
                {
                    if (success.Value.ToString().Equals("0"))
                        Response.Write("Offer not found!");

                    else
                        Response.Write("Offer not not yet expired!");
                }
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