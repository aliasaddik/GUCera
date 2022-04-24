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
    public partial class feedback : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                errorl.Text = err.Message;

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
          
                int id = (int)Session["user"];
               
                SqlCommand com = new SqlCommand("select c.name As CourseName , st.cid From Course c inner join StudentTakeCourse st on st.sid = @id and c.id = st.cid", conn);
                com.Parameters.Add(new SqlParameter("@id", id));
                GridView grid = new GridView();
                grid.CssClass = "rtable";
                grid.EmptyDataText = "Students enrolled in No courses";
                conn.Open();
                grid.DataSource = com.ExecuteReader();
                grid.DataBind();
                form1.Controls.Add(grid);
                conn.Close();
            }
            catch(Exception ex)
            {
                errorl.Text = ex.Message;
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
               
                int id = (int)Session["user"];
                
                String cmmnt = comment.Text;
                SqlCommand addfeed = new SqlCommand("addFeedback", conn);
                addfeed.CommandType = CommandType.StoredProcedure;
                addfeed.Parameters.Add(new SqlParameter("@sid", id));
                addfeed.Parameters.Add(new SqlParameter("@cid ", Course.Text));
                addfeed.Parameters.Add(new SqlParameter("@comment ", cmmnt));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                addfeed.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                errorl.Text = ex.Message;
            }
        }
    }
    }

    
