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
    public partial class addassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label.Text =  err.Message;

            }
        }

        protected void Add_assign(object sender , EventArgs e)
        { 
            try
            {
                
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
                Label.Text = "";
                int instid = (int)Session["user"];
            
            
            
                int cid = Int16.Parse(courseid.Text);
                int aid = Int16.Parse(assignum.Text);
                int fg = Int16.Parse(fullg.Text);
                int w = Int16.Parse(assignw.Text);
           
             
                String type = assignt.Text;
            
           
            DateTime deadline = DateTime.Parse(deadl.Text);
            String content = assigncontent.Text;
            SqlCommand DefineAssignmentOfCourseOfCertianTypeproc = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            DefineAssignmentOfCourseOfCertianTypeproc.CommandType = CommandType.StoredProcedure;
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@instId", instid));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@cid", cid));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@number", aid));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@type",type));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@fullGrade", fg));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@weight", w));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@deadline", deadline));
            DefineAssignmentOfCourseOfCertianTypeproc.Parameters.Add(new SqlParameter("@content", content));
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            DefineAssignmentOfCourseOfCertianTypeproc.ExecuteNonQuery();
             
            conn.Close();
            }

            catch (Exception ex)
            {
                Label.Text = ex.Message;
            }
        }
    }
}