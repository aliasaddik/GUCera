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

    public partial class assignments : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {

                Label3.Text = err.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            SqlCommand courses = new SqlCommand("Select c.name as CourseName , c.id From Course  c inner join StudentTakeCourse st on c.id = st.cid and st.sid = @id ", conn);
            courses.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            GridView grid = new GridView();
            grid.CssClass = "rtable";
            grid.EmptyDataText = "Students enrolled in No courses";
            grid.DataSource = courses.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void viewAssign_Click(object sender, EventArgs e)
        {
            try
            {
                Label3.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand assignments = new SqlCommand("viewAssign", conn);
                assignments.CommandType = CommandType.StoredProcedure;
                int id = (int)Session["user"];

                String ccid = cid.Text;
                assignments.Parameters.Add(new SqlParameter("@courseId", ccid));
                assignments.Parameters.Add(new SqlParameter("@Sid", id));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                GridView grid = new GridView();
                grid.CssClass ="rtable";
                grid.EmptyDataText = "No records available";
                grid.DataSource = assignments.ExecuteReader();
                grid.DataBind();
                form1.Controls.Add(grid);
                conn.Close();

            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
                return;
            }
        }
    }
}
     
