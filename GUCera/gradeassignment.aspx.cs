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

    public partial class gradeassignment : System.Web.UI.Page
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


        protected void grade_ass(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int instid = (int)Session["user"];
                int sid = Int16.Parse(studentID.Text);
                int cid = Int16.Parse(courseID.Text);
                int assnum = Int16.Parse(assignn.Text);
                String assignt = asstype.Text;
                decimal assg = decimal.Parse(assgrade.Text);


                SqlCommand InstructorgradeAssignmentOfAStudentproc = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                InstructorgradeAssignmentOfAStudentproc.CommandType = CommandType.StoredProcedure;
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@instrId", instid));
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@sid", sid));
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@cid", cid));
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@assignmentNumber", assnum));
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@type", assignt));
                InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@grade", assg));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                InstructorgradeAssignmentOfAStudentproc.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
            }

        }
    }
}