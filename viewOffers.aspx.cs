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
    public partial class viewOffers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void viewOffer(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("viewOffers", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string vendor = Session["field1"].ToString();
            cmd.Parameters.Add(new SqlParameter("@vendor", vendor));

            conn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Columns.Add("Offer ID", typeof(int));
            dt.Columns.Add("Offer Amount", typeof(decimal));
            dt.Columns.Add("Expiry Date", typeof(DateTime));

            while (rdr.Read())
            {
                string offer_ID = "N/A";
                string offer_amount = "N/A";
                string expiry_date = "N/A";

                if (!rdr.IsDBNull(0))
                    offer_ID = rdr.GetInt32(rdr.GetOrdinal("offer_id")).ToString();

                if (!rdr.IsDBNull(1))
                    offer_amount = rdr.GetInt32(rdr.GetOrdinal("offer_amount")).ToString();

                if (!rdr.IsDBNull(2))
                    expiry_date = rdr.GetDateTime(rdr.GetOrdinal("expiry_date")).ToString();

                dt.Rows.Add(offer_ID, offer_amount, expiry_date);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            conn.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["field1"] = "";
            Response.Redirect("Login.aspx", true);
        }
    }
}