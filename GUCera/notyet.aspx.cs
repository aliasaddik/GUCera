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
    public partial class notyet : System.Web.UI.Page
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
            try
            {
                Label3.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand shownotyet = new SqlCommand("AdminViewNonAcceptedCourses", conn);
                shownotyet.CommandType = CommandType.StoredProcedure;
                conn.Open();

                Label courses = new Label();
                courses.CssClass = "label";
                courses.Text = "Pending Courses";
                form1.Controls.Add(courses);

                GridView grid = new GridView();
                  grid.CssClass = "rtable";
                  grid.EmptyDataText = "No pending courses";
                    grid.DataSource = shownotyet.ExecuteReader();
                    grid.DataBind();
                    form1.Controls.Add(grid);
               conn.Close();


                    //div.Controls.Add(name);
                    //form1.Controls.Add(div);
                

            }
            catch(Exception ex)
            {
                Label3.Text = ex.Message;
                return;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Label3.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int cid = Int16.Parse(courseid.Text);
                int aid = (int)Session["user"];
                SqlCommand acceptcourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                acceptcourse.CommandType = CommandType.StoredProcedure;
                acceptcourse.Parameters.Add(new SqlParameter("@adminid", aid));
                acceptcourse.Parameters.Add(new SqlParameter("@courseId", cid));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

                acceptcourse.ExecuteNonQuery();

                conn.Close();
                //Response.Redirect("notyet.aspx");
                //Response.Write("you accepted the course successfully");
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
                return;
            }

        }
    }
}