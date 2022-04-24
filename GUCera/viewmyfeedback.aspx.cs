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
    public partial class viewmyfeedback : System.Web.UI.Page
    {


        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {

                Label2.Text = err.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_myfeed(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int instid = (int)Session["user"];
                int cidd = Int16.Parse(cid.Text);
                SqlCommand ViewFeedbacksAddedByStudentsOnMyCourseproc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                ViewFeedbacksAddedByStudentsOnMyCourseproc.CommandType = CommandType.StoredProcedure;
                ViewFeedbacksAddedByStudentsOnMyCourseproc.Parameters.Add(new SqlParameter("@instrId", instid));
                ViewFeedbacksAddedByStudentsOnMyCourseproc.Parameters.Add(new SqlParameter("@cid", cidd));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                ViewFeedbacksAddedByStudentsOnMyCourseproc.ExecuteNonQuery();
                SqlDataReader rdr = ViewFeedbacksAddedByStudentsOnMyCourseproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    HtmlGenericControl div = new HtmlGenericControl("div");
                    Label name = new Label();
                    Int32 comnum = (rdr.GetInt32(rdr.GetOrdinal("number")));
                    String comment = rdr.GetString(rdr.GetOrdinal("comment"));
                    Int32 nolikes = (rdr.GetInt32(rdr.GetOrdinal("numberOfLikes")));
                    name.Text += "Comment Number:" + comnum + " Comment:" + comment + " # of likes:" + nolikes;
                    div.Controls.Add(name);
                    form1.Controls.Add(div);
                }
                conn.Close();
            }catch(Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }
    }
}