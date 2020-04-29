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
    public partial class mainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
            SqlCommand cmd = new SqlCommand("ShowProductsbyPrice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
         

            conn.Open();
            

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Columns.Add("Serial Number",typeof(int));
            dt.Columns.Add("Product Name", typeof(String));
            dt.Columns.Add("Category", typeof(String));
            dt.Columns.Add("Product Description", typeof(String));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Final Price", typeof(decimal));
            dt.Columns.Add("Color", typeof(String));
            dt.Columns.Add("Avaliable", typeof(String));
            dt.Columns.Add("Rate", typeof(int));
            dt.Columns.Add("Vendor Username", typeof(String));
            dt.Columns.Add("Customer Username", typeof(String));
            dt.Columns.Add("Customer Order ID", typeof(int));
            while (rdr.Read())
            {
                int serial_no = 0;
                string product_name = "N/A";
                string category = "N/A";
                string product_description = "N/A";
                decimal price = 0;
                decimal final_price = 0;
                string avaliable = "False";
                string color = "N/A";
                string rate = "N/A";
                string vendor_username = "N/A";
                string customer_username = "N/A";
                int customer_order_id = 0;

                //Get the value of the attribute name in the Company table
                if (rdr.IsDBNull(0) == false)
                {
                    serial_no = rdr.GetInt32(rdr.GetOrdinal("serial_no"));
                }
                //Get the value of the attribute field in the Company table
                if (rdr.IsDBNull(1) == false)
                {
                    product_name = rdr.GetString(rdr.GetOrdinal("product_name"));
                }
                if (rdr.IsDBNull(2) == false)
                    category = rdr.GetString(rdr.GetOrdinal("category"));
                if (rdr.IsDBNull(3) == false)
                    product_description = rdr.GetString(rdr.GetOrdinal("product_description"));
                if (rdr.IsDBNull(4) == false)
                    price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                if (rdr.IsDBNull(5) == false)
                    final_price =rdr.GetDecimal(rdr.GetOrdinal("final_price"));
                if (rdr.IsDBNull(6) == false)
                    color = rdr.GetString(rdr.GetOrdinal("color"));
                if (rdr.IsDBNull(7) == false && rdr.GetBoolean(rdr.GetOrdinal("available"))==true)
                   avaliable ="True";
                if (rdr.IsDBNull(8) == false)
                    rate = rdr.GetInt32(rdr.GetOrdinal("rate")).ToString();
                if (rdr.IsDBNull(9) == false)
                    vendor_username = rdr.GetString(rdr.GetOrdinal("vendor_username"));
                if (rdr.IsDBNull(10) == false)
                    customer_username = rdr.GetString(rdr.GetOrdinal("customer_username"));
                if (rdr.IsDBNull(11) == false)
                    customer_order_id = rdr.GetInt32(rdr.GetOrdinal("customer_order_id"));

                dt.Rows.Add(serial_no, product_name, category, product_description,
                    price, final_price, color, avaliable, rate, vendor_username, customer_username,
                    customer_order_id);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
       
    }
    }
