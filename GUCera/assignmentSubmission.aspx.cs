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
    public partial class assignmentSubmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            SqlCommand assignments = new SqlCommand("Select a.number as AssignmentNumber ,a.type as AssigmentType , st.cid as CourseID , c.name AS CourseName From Assignment a  inner join StudentTakeCourse st on a.cid = st.cid and st.sid = @id inner join Course c on c.id = st.cid ", conn);
            assignments.Parameters.Add(new SqlParameter("@id", id));
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            GridView grid = new GridView();
            grid.CssClass="rtable";
            grid.EmptyDataText = "No records available";
            grid.DataSource = assignments.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();

        }
        protected  void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label4.Text = err.Message;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {   try
            {
                Label4.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand submitAssignment = new SqlCommand("submitAssign", conn);
                int id = (int)Session["user"];
                String cidd = courseId.Text;
                int cid = (int)Convert.ToInt32(cidd);
                String assNo = no.Text;
                int number = (int)Convert.ToInt64(assNo);
                submitAssignment.CommandType = CommandType.StoredProcedure;
                submitAssignment.Parameters.Add(new SqlParameter("@sid", id));
                submitAssignment.Parameters.Add(new SqlParameter("@cid", cid));
                submitAssignment.Parameters.Add(new SqlParameter("@assignnumber", number));
                String Type = "";
                if(type.SelectedIndex != 0 && type.SelectedIndex != 1 && type.SelectedIndex != 2)
                {
                    Label4.Text = "You must choose a type";
                    return;
                }
                if (type.SelectedIndex == 0)
                {
                    Type = "quiz";
                }
                else if (type.SelectedIndex == 1)
                {
                    Type = "project";
                }
                else if (type.SelectedIndex == 2)
                {
                    Type = "Exam";
                }

                submitAssignment.Parameters.Add(new SqlParameter("@assignType", Type));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                
                submitAssignment.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                Label4.Text = ex.Message;
            }
            
        }
    }
}