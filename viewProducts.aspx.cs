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
    public partial class viewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void vendorviewProducts(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("vendorviewProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string vendor = Session["field1"].ToString();
            cmd.Parameters.Add(new SqlParameter("@vendorname", vendor));

            conn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Columns.Add("Serial Number", typeof(int));
            dt.Columns.Add("Product Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Product Description", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Final Price", typeof(decimal));
            dt.Columns.Add("Colour", typeof(string));

            while (rdr.Read())
            {
                int serial_num = 0;
                string product_name = "N/A";
                string category = "N/A";
                string product_description = "N/A";
                decimal price = 0;
                decimal final_price = 0;
                string colour = "N/A";

                if (!rdr.IsDBNull(0))
                    serial_num = rdr.GetInt32(rdr.GetOrdinal("serial_no"));

                if (!rdr.IsDBNull(1))
                    product_name = rdr.GetString(rdr.GetOrdinal("product_name")).ToString();

                if (!rdr.IsDBNull(2))
                    category = rdr.GetString(rdr.GetOrdinal("category")).ToString();

                if (!rdr.IsDBNull(3))
                    product_description = rdr.GetString(rdr.GetOrdinal("product_description")).ToString();

                if (!rdr.IsDBNull(4))
                    price = rdr.GetDecimal(rdr.GetOrdinal("price"));

                if (!rdr.IsDBNull(5))
                    final_price = rdr.GetDecimal(rdr.GetOrdinal("final_price"));

                if (!rdr.IsDBNull(6))
                    colour = rdr.GetString(rdr.GetOrdinal("color")).ToString();

                dt.Rows.Add(serial_num, product_name, category, product_description, price, final_price, colour);
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