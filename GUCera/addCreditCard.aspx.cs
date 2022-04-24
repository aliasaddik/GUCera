using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class addCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addCard(object sender, EventArgs e)

        { try
            {
                Label.Text = "";
                int id = (int)Session["user"];
                string cnumber = number.Text;
                string holder = name.Text;
                
                string ccvv = cvv.Text;
                if( (cnumber== "")  || (holder=="")|| ccvv=="" || date.Text=="")

                {
                    Label.Text = "All field are required, Please enter all fields";
                    return;
                }
                DateTime expiry = DateTime.Parse(date.Text);


                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
                addCreditCard.CommandType = CommandType.StoredProcedure;
                addCreditCard.Parameters.Add(new SqlParameter("@sid", id));
                addCreditCard.Parameters.Add(new SqlParameter("@number", cnumber));
                addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName ", holder));
                addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", expiry));
                addCreditCard.Parameters.Add(new SqlParameter("@cvv", ccvv));
                conn.Open();
                addCreditCard.ExecuteNonQuery();
                conn.Close();
                Label.Text = "Card Added Successfully!";



            }
            catch (Exception ex)
            {
                Label.Text = ex.Message;
                return;
            }
            }


    }
}