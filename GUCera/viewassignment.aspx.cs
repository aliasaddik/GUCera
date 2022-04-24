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
    public partial class viewassignment : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {

                Label1.Text = err.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_submitted(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int instid = (int)Session["user"];
                int cid = Int16.Parse(crsid.Text);
                SqlCommand InstructorViewAssignmentsStudentsproc = new SqlCommand("InstructorViewAssignmentsStudents", conn);
                InstructorViewAssignmentsStudentsproc.CommandType = CommandType.StoredProcedure;
                InstructorViewAssignmentsStudentsproc.Parameters.Add(new SqlParameter("@instrId", instid));
                InstructorViewAssignmentsStudentsproc.Parameters.Add(new SqlParameter("@cid", cid));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                InstructorViewAssignmentsStudentsproc.ExecuteNonQuery();
                SqlDataReader rdr = InstructorViewAssignmentsStudentsproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    HtmlGenericControl div = new HtmlGenericControl("div");
                    Label name = new Label();
                    Int32 stuID = (rdr.GetInt32(rdr.GetOrdinal("sid")));
                    Int32 courseID = (rdr.GetInt32(rdr.GetOrdinal("cid")));
                    Int32 assignum = (rdr.GetInt32(rdr.GetOrdinal("assignmentNumber")));
                    String assignt = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                    name.Text += "StudentId:" + stuID + "CourseID:" + courseID + "Assignment#:" + assignum + "AssignmentType:" + assignt;
                    div.Controls.Add(name);
                    form1.Controls.Add(div);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

    }
}