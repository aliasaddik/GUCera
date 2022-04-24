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
    public partial class issuecertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                errorl.Text = err.Message;

            }
        }


        protected void issue_c(object sender,EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int cid = Int16.Parse(couID.Text);
                int sid = Int16.Parse(stuID.Text);
                int instid = (int)Session["user"];
                DateTime issued = DateTime.Parse(issdate.Text);
                SqlCommand InstructorIssueCertificateToStudentproc = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                InstructorIssueCertificateToStudentproc.CommandType = CommandType.StoredProcedure;
                InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@cid", cid));
                InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@sid", sid));
                InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@insId", instid));
                InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@issueDate", issued));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                InstructorIssueCertificateToStudentproc.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                errorl.Text = ex.Message;
            }
            
        }
    }
}