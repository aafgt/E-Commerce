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
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register1(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("vendorRegister", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string first_name = txt_first_name.Text;
            string last_name = txt_last_name.Text;
            string username = txt_username.Text;
            String password = txt_password.Text;
            string email = txt_email.Text;
            string company_name = txt_companyname.Text;
            string bank_acc_no = txt_bank_acc_no.Text;

            //pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@first_name", first_name));
            cmd.Parameters.Add(new SqlParameter("@last_name", last_name));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@company_name", company_name));
            cmd.Parameters.Add(new SqlParameter("@bank_acc_no", bank_acc_no));

            //Save the output from the procedure
            //Executing the SQLCommand
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("Register is complete");
            }
            catch (Exception x)
            {
                if (x.Message.Contains("duplicate"))
                    Response.Write("This username already exsits");
            }
        }
    }
    }

