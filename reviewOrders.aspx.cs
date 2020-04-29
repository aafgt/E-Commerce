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
    public partial class reviewOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string username = (string)(Session["field1"]);
            if (username == "" || username == null)
            {
                Response.Redirect("Login.aspx", true);
            }
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("reviewOrders", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            conn.Open();


            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Columns.Add("Order Number", typeof(int));
            dt.Columns.Add("Order Date", typeof(DateTime));
            dt.Columns.Add("Total Amount", typeof(decimal));
            dt.Columns.Add("Cash Amount", typeof(decimal));
            dt.Columns.Add("Credit Amount", typeof(decimal));
            dt.Columns.Add("Payment Type", typeof(string));
            dt.Columns.Add("Order Status", typeof(String));
            dt.Columns.Add("Remaining Days", typeof(int));
            dt.Columns.Add("Time Limit", typeof(int));
            dt.Columns.Add("Gift Card Code Used", typeof(String));
            dt.Columns.Add("Customer Name", typeof(String));
            dt.Columns.Add("Credit Card Number", typeof(String));
            dt.Columns.Add("Delivery ID", typeof(int));
            while (rdr.Read())
            {
                string order_no = "N/A";
                string order_date = "N/A";
                string total_amount = "0.0";
                string cash_amount = "N/A";
                string credit_amount = "N/A";
                string payment_type = "N/A";
                string order_status = "False";
                string remaining_days = "0";
                string time_limit = "0";
                string Gift_Card_code_used = "N/A";
                string customer_name = "N/A";
                string creditCard_number = "N/A";
                string delivery_id = "0";

                //Get the value of the attribute name in the Company table
                if (rdr.IsDBNull(0) == false)
                {
                    order_no = rdr.GetInt32(rdr.GetOrdinal("order_no")).ToString();
                }
                //Get the value of the attribute field in the Company table
                if (rdr.IsDBNull(1) == false)
                {
                    order_date = rdr.GetDateTime(rdr.GetOrdinal("order_date")).ToString();
                }
                if (rdr.IsDBNull(2) == false)
                    total_amount = rdr.GetDecimal(rdr.GetOrdinal("total_amount")).ToString();
                if (rdr.IsDBNull(3) == false)
                    cash_amount = rdr.GetDecimal(rdr.GetOrdinal("cash_amount")).ToString();
                if (rdr.IsDBNull(4) == false)
                    credit_amount = rdr.GetDecimal(rdr.GetOrdinal("credit_amount")).ToString();
                if (rdr.IsDBNull(5) == false)
                    payment_type = rdr.GetString(rdr.GetOrdinal("payment_type"));
                if (rdr.IsDBNull(6) == false)
                    order_status = rdr.GetString(rdr.GetOrdinal("order_status"));
                if (rdr.IsDBNull(7) == false)
                    remaining_days = rdr.GetInt32(rdr.GetOrdinal("remaining_days")).ToString();
                if (rdr.IsDBNull(8) == false)
                    time_limit = rdr.GetInt32(rdr.GetOrdinal("time_limit")).ToString();
                if (rdr.IsDBNull(9) == false)
                    Gift_Card_code_used = rdr.GetString(rdr.GetOrdinal("Gift_Card_code_used"));
                if (rdr.IsDBNull(10) == false)
                    customer_name = rdr.GetString(rdr.GetOrdinal("customer_name"));
                if (rdr.IsDBNull(11) == false)
                    creditCard_number = rdr.GetString(rdr.GetOrdinal("creditCard_number"));
                if (rdr.IsDBNull(12) == false)
                    delivery_id = rdr.GetInt32(rdr.GetOrdinal("delivery_id")).ToString();


                dt.Rows.Add(order_no, order_date, total_amount, cash_amount,
                    credit_amount, payment_type, order_status, remaining_days, time_limit, Gift_Card_code_used, customer_name,
                    creditCard_number, delivery_id);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }    }
    }
}