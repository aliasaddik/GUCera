using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class promocode : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label4.Text = err.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
            
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Label4.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                DateTime issue = DateTime.Now;
                DateTime expiry = DateTime.Parse(expirydate.Text);
                String pcode = code.Text;
                Decimal disc = Decimal.Parse(discount.Text);
                int id = (int)Session["user"];
                SqlCommand createpromo = new SqlCommand("AdminCreatePromocode", conn);
                createpromo.CommandType = CommandType.StoredProcedure;
                createpromo.Parameters.Add(new SqlParameter("@code", pcode));
                createpromo.Parameters.Add(new SqlParameter("@isuueDate", issue));
                createpromo.Parameters.Add(new SqlParameter("@expiryDate", expiry));
                createpromo.Parameters.Add(new SqlParameter("@discount", disc));
                createpromo.Parameters.Add(new SqlParameter("@adminId", id));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                createpromo.ExecuteNonQuery();
                conn.Close();
                //Response.Write("you added the promocode successfully");
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
                return;
            }
        }




    }
    }
