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
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                
                Label1.Text = err.Message;
              

            }
        }


        protected void student_Click(object sender, EventArgs e)
        {
             
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            while(gender.SelectedIndex != 0 && gender.SelectedIndex != 1)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = "please select a gender";
                form1.Controls.Add(tag); 
                return;

            }
            string f_name = firstname.Text;
            string l_name = lastname.Text;
            string pass = password.Text;
            string e_mail = email.Text;
            string add = address.Text;
            int gen = gender.SelectedIndex;
            while(f_name =="" || l_name=="" || pass=="" || e_mail=="" || add==""  )
            {
                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = "please enter a valid input in the empty feild";
                form1.Controls.Add(tag);
                return;
            }

            SqlCommand studentregproc = new SqlCommand("studentRegister", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;
            studentregproc.Parameters.Add(new SqlParameter("@first_name", f_name));
            studentregproc.Parameters.Add(new SqlParameter("@last_name", l_name));
            studentregproc.Parameters.Add(new SqlParameter("@password", pass));
            studentregproc.Parameters.Add(new SqlParameter("@email", e_mail));
            studentregproc.Parameters.Add(new SqlParameter("@address", add));
            studentregproc.Parameters.Add(new SqlParameter("@gender", gen));

            SqlCommand getid = new SqlCommand("select max(id) as yourID from Users", conn);
             
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            studentregproc.ExecuteNonQuery();
            
            conn.Close();

            conn.Open();
            GridView grid = new GridView();
            grid.CssClass = "rtable";
            grid.EmptyDataText = "No records available";
            grid.DataSource = getid.ExecuteReader();
            grid.DataBind();
            table.Controls.Add(grid);
            conn.Close();

        }
        
            protected void instructor_Click(object sender, EventArgs e)
        {
             
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            while (gender.SelectedIndex != 0 && gender.SelectedIndex != 1)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = "please select a gender";
                form1.Controls.Add(tag);
                return;

            }
            string f_name = firstname.Text;
            string l_name = lastname.Text;
            string pass = password.Text;
            string e_mail = email.Text;
            string add = address.Text;
            int gen = gender.SelectedIndex;
            while(f_name == "" || l_name == "" || pass == "" || e_mail == "" || add == "")
            {
                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = "please enter a valid input in the empty feild";
                form1.Controls.Add(tag);
                return;
            }

            SqlCommand studentregproc = new SqlCommand("InstructorRegister", conn);
            studentregproc.CommandType = CommandType.StoredProcedure;
            studentregproc.Parameters.Add(new SqlParameter("@first_name", f_name));
            studentregproc.Parameters.Add(new SqlParameter("@last_name", l_name));
            studentregproc.Parameters.Add(new SqlParameter("@password", pass));
            studentregproc.Parameters.Add(new SqlParameter("@email", e_mail));
            studentregproc.Parameters.Add(new SqlParameter("@address", add));
            studentregproc.Parameters.Add(new SqlParameter("@gender", gen));
            SqlCommand getid = new SqlCommand("select max(id) as yourID from Users", conn);
             
            
            
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage); 
            studentregproc.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            GridView grid = new GridView();
            grid.CssClass = "rtable";
            grid.EmptyDataText = "No records available";
            grid.DataSource = getid.ExecuteReader();
            grid.DataBind();
            table.Controls.Add(grid);
            conn.Close();


        }

       
            
            protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }
    }
}