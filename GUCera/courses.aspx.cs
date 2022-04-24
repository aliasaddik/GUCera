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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand courses = new SqlCommand("availableCourses", conn);
                int id = (int)Session["user"];
                courses.CommandType = CommandType.StoredProcedure;
                courses.Parameters.Add(new SqlParameter("@sid", id));
                conn.Open();
                SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    string courseName = (string)rdr["name"];
                    int courseID = (int)rdr["id"];
                    Button btn = new Button();
                    btn.Text = "view Course Details";
                    btn.ID = courseName;
                    btn.CssClass = "button";
                    btn.Click += (s, ev) => {
                        Session["courseID"] = courseID;
                        Session["courseName"] = courseName;
                        Response.Redirect("coursePage.aspx");
                    };

                    System.Web.UI.HtmlControls.HtmlGenericControl div = new HtmlGenericControl("div");
                    div.Attributes.Add("class", "card");
                    div.Attributes.Add("class", "container");
                    System.Web.UI.HtmlControls.HtmlGenericControl name = new HtmlGenericControl("h3");
                    name.InnerText = courseName;
                    div.Controls.Add(name);
                    div.Controls.Add(btn);
                    form1.Controls.Add(div);

                }

            }
            catch(Exception ex)
            {
                Label1.Text = "You have to login First";
            }
            }
       
    }
}