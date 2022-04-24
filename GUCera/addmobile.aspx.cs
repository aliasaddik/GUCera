using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
namespace GUCera
{
    public partial class addmobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string mobile = mobileno.Text;
            while(mobile == "")
            {
                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = "please enter a mobile number";
                form1.Controls.Add(tag);
                return;
            }
            int id = (int)Session["user"];
             
            SqlCommand addmobileproc = new SqlCommand("addMobile", conn);
            addmobileproc.CommandType = CommandType.StoredProcedure;
            addmobileproc.Parameters.Add(new SqlParameter("@ID", id));
            addmobileproc.Parameters.Add(new SqlParameter("@mobile_number",mobile));
            conn.Open();
            addmobileproc.ExecuteNonQuery();
            conn.Close();
            Label2.Text = "you added the mobile number successfully";



        }
        static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
             
            var outputFromStoredProcedure = e.Message;
        }
    }
}