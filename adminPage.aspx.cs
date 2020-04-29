using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("activateVendor.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("reviewOrders.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateOrderStatusInProcess.aspx", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("createTodaysDeal.aspx", true);
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["field1"] = "";
            Response.Redirect("Default.aspx", true);
        }
    }
}