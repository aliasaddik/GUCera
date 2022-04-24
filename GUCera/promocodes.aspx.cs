using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class promocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand promocodes = new SqlCommand("viewPromocode", conn);
                promocodes.CommandType = CommandType.StoredProcedure;
                int sid = (int)Session["user"];
                promocodes.Parameters.Add(new SqlParameter("@sid", sid));
                conn.Open();

                GridView grid1 = new GridView();
                grid1.CssClass = "rtable";
                grid1.EmptyDataText = "No promocodes available";
                grid1.DataSource = promocodes.ExecuteReader();
                grid1.DataBind();
                form1.Controls.Add(grid1);
                conn.Close();

            }
            catch(Exception ex) {
                label1.Text = ex.Message;
            }
        }
    }
}