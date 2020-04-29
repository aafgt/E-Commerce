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
    public partial class createTodaysDeal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("addTodaysDealOnProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string deal_id = TextBox1.Text;
            string serial_no = TextBox2.Text;

            if (deal_id == "" || serial_no == "")
            {
                Response.Write("deal id or serial number is missing");
            }
            else
            {
                SqlCommand cmd3 = new SqlCommand("isProduct", conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add(new SqlParameter("@serial_no", serial_no));
                SqlParameter success = cmd3.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("there is no product with this serial number");
                }
                else
                {
                    SqlCommand cmd4 = new SqlCommand("isDeal", conn);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.Add(new SqlParameter("@deal_id", deal_id));
                    SqlParameter success3 = cmd4.Parameters.Add("@success", SqlDbType.Int);
                    success3.Direction = ParameterDirection.Output;
                    conn.Open();
                    cmd4.ExecuteNonQuery();
                    conn.Close();

                    if (success3.Value.ToString().Equals("0"))
                    {
                        Response.Write("there is no deal with this deal id");
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("checkTodaysDealOnProduct", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add(new SqlParameter("@serial_no", serial_no));
                        SqlParameter success2 = cmd2.Parameters.Add("@activeDeal", SqlDbType.Int);
                        success2.Direction = ParameterDirection.Output;
                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();

                        if (success2.Value.ToString().Equals("1"))
                        {
                            Response.Write("there is an active today deal on this product already");
                        }
                        else
                        {
                            SqlCommand cmd5 = new SqlCommand("applyDeal", conn);
                            cmd5.CommandType = CommandType.StoredProcedure;
                            cmd5.Parameters.Add(new SqlParameter("@deal_id", deal_id));
                            cmd5.Parameters.Add(new SqlParameter("@serial_no", serial_no));
                            conn.Open();
                            cmd5.ExecuteNonQuery();
                            conn.Close();



                            //pass parameters to the stored procedure
                            cmd.Parameters.Add(new SqlParameter("@deal_id", deal_id));
                            cmd.Parameters.Add(new SqlParameter("@serial_no", serial_no));

                            //Save the output from the procedure
                            //Executing the SQLCommand
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response.Write("todays deal added successfully on product");
                        }
                    }
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("removeExpiredDeal", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string deal_iD = TextBox3.Text;

            if (deal_iD == "")
            {
                Response.Write("deal ID is missing");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("isDeal", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@deal_id", deal_iD));
                SqlParameter success = cmd2.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("there is no deal with this deal id");
                }
                else
                {
                    //pass parameters to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@deal_iD", deal_iD));

                    //Save the output from the procedure
                    //Executing the SQLCommand
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("All expired deals removed");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("createTodaysDeal", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //To read the input from the user
            string deal_amount = TextBox4.Text;
            string expiry_date = TextBox6.Text;

            string username = (string)(Session["field1"]);

            if (deal_amount == "" || expiry_date == "")
            {
                Response.Write("deal amount or expiry date is missing");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("isAdmin", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@admin_username", username));
                SqlParameter success = cmd2.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString().Equals("0"))
                {
                    Response.Write("not an admin");
                }
                else
                {
                    //pass parameters to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@deal_amount", deal_amount));
                    cmd.Parameters.Add(new SqlParameter("@admin_username", username));
                    cmd.Parameters.Add(new SqlParameter("@expiry_date", expiry_date));

                    //Save the output from the procedure
                    //Executing the SQLCommand
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("today deal created");
                }
            }
        }
    }
}