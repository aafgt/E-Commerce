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
    public partial class postProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void postProduct(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("postProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                string vendor = Session["field1"].ToString();
                string productName = txt_product_name.Text;
                string category = txt_category.Text;
                string productDescription = txt_product_description.Text;
                decimal price = decimal.Parse(txt_price.Text);
                string colour = txt_colour.Text;

                cmd.Parameters.Add(new SqlParameter("@vendorUsername", vendor));
                cmd.Parameters.Add(new SqlParameter("@product_name", productName));
                cmd.Parameters.Add(new SqlParameter("@category", category));
                cmd.Parameters.Add(new SqlParameter("@product_description", productDescription));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@color", colour));

                SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                //Executing the SQLCommand
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("1"))
                    Response.Write("Posted!");

                else
                    Response.Write("One of the boxes is missing!");
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