using System;
using System.Collections;
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
    public partial class addCreditCarPage : System.Web.UI.Page
    {
      //  ArrayList cardList = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
        }

        protected void add_card_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("AddCreditCard", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string card = txt_card_number.Text;
            string cvv = txt_cvv.Text;
            string username = (string)(Session["field1"]);
            if (card == "" || card == null || txt_date.Text == "" || txt_date.Text == null || cvv == null || cvv == "")
            {
                Response.Write("The Credit Card Number, Expiry Date, or CVV is Missing");
            }
            else
            {
                 DateTime date1 = DateTime.Parse(txt_date.Text);
                //pass parameters to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@customername", username));
                cmd.Parameters.Add(new SqlParameter("@creditcardnumber", card));
                cmd.Parameters.Add(new SqlParameter("@expirydate", date1));
                cmd.Parameters.Add(new SqlParameter("@cvv", cvv));

            //Save the output from the procedure
            //Executing the SQLCommand
            
            
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Credit Card is Added");
                }
                catch (Exception x)
                {
                    if (x.Message.Contains("duplicate"))
                        Response.Write("This Credit Card is already Added");
                }
            }
        }
    }
}