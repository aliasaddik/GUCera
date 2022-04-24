using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class certificates : System.Web.UI.Page
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

            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            conn.Open();
            SqlCommand com = new SqlCommand("select c.name as CourseName ,c.id as CourseId From Course c inner join StudentCertifyCourse sc on sc.cid=c.id and sc.sid= @id ", conn);
            com.Parameters.Add(new SqlParameter("@id", id));
            // table name  
            GridView grid = new GridView();
            grid.CssClass = "rtable";
            grid.EmptyDataText = "No records available";
            grid.DataSource = com.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Text = "";

            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            SqlCommand viewCertificate = new SqlCommand("viewCertificate", conn);
            viewCertificate.CommandType = CommandType.StoredProcedure;
            viewCertificate.Parameters.Add(new SqlParameter("@sid", id));
            viewCertificate.Parameters.Add(new SqlParameter("@cid ", course.Text));
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

            GridView grid = new GridView();
            grid.CssClass = "rtable";
            grid.EmptyDataText = "No records available";
            grid.DataSource = viewCertificate.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();


        }



    }
}