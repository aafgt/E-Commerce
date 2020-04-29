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
    public partial class editProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void editProduct(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("EditProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                string vendor = Session["field1"].ToString();
                int serialNum = int.Parse(TextBox1.Text);
                string productName = TextBox2.Text;
                string category = TextBox3.Text;
                string productDescp = TextBox4.Text;
                decimal price = decimal.Parse(TextBox5.Text);
                string colour = TextBox6.Text;

                cmd.Parameters.Add(new SqlParameter("@vendorname", vendor));
                cmd.Parameters.Add(new SqlParameter("@serialnumber", serialNum));
                cmd.Parameters.Add(new SqlParameter("@product_name", productName));
                cmd.Parameters.Add(new SqlParameter("@category", category));
                cmd.Parameters.Add(new SqlParameter("@product_description", productDescp));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@color", colour));

                SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("1"))
                    Response.Write("Edited!");

                else
                    Response.Write("Product not found!");
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