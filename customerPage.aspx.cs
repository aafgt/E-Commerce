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
    public partial class customerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }

        protected void ViewProducts(object sender, EventArgs e)
        {
            Response.Redirect("ProductPage.aspx", true);
        }

        protected void createwishlist(object sender, EventArgs e)
        {
            Response.Redirect("createwishlistPage.aspx", true);
        }

        protected void AddToWishlist(object sender, EventArgs e)
        {
            Response.Redirect("addtowishlistPage.aspx", true);
        }

        protected void AddPhone(object sender, EventArgs e)
        {
            Response.Redirect("addphonePage.aspx", true);
        }

        protected void remove_From_Wishlist(object sender, EventArgs e)
        {
            Response.Redirect("removefromwishlistPage.aspx", true);
        }

        protected void addtocart_Click(object sender, EventArgs e)
        {
            Response.Redirect("addtocartPage.aspx", true);
        }

        protected void removefromcart_Click(object sender, EventArgs e)
        {
            Response.Redirect("removefromcartPage.aspx", true);
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["field1"] = "";
            Response.Redirect("Default.aspx", true);
        }

        protected void addcreditcard_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcreditcardPage.aspx", true);
        }
        protected void Pay(object sender, EventArgs e)
        {
            Response.Redirect("Pay.aspx", true);
        }

        protected void CreateOrder(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("makeOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            String username = Session["field1"].ToString();

            cmd.Parameters.Add(new SqlParameter("@customername", username));
            SqlParameter orderID = cmd.Parameters.Add("@orderID", SqlDbType.Int);
            SqlParameter total = cmd.Parameters.Add("@total", SqlDbType.Int);
            orderID.Direction = ParameterDirection.Output;
            total.Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (orderID.Value.ToString().Equals(""))
                {
                    Response.Write("No Items Found In Your Cart");
                }
                else
                {
                    Response.Write("Your Order Has Been Made With Order ID : " + orderID.Value.ToString());
                    Response.Write("</br>" + "The Total Price is : " + total.Value.ToString());
                }

            }
            catch (Exception)
            {
                if (orderID.Value.ToString().Equals(""))
                {
                    Response.Write("No Items Found In Your Cart");
                }
                else
                {
                    Response.Write("Your Order Has Been Made With Order ID : " + orderID.Value.ToString());
                    Response.Write("</br>" + "The Total Price is : " + total.Value.ToString());
                }
            }
        }
        protected void CancelOrders(object sender, EventArgs e)
        {
            Response.Redirect("CancellingOrders.aspx", true);
        }
        protected void ChooseCredit(object sender, EventArgs e)
        {
            Response.Redirect("ChooseCreditCard.aspx", true);
        }
    }
}