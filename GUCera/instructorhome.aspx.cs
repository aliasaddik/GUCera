using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class instructorhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mobile_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmobile.aspx");
        }

        protected void course_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcourse.aspx");
        }


        protected void assign_Click(object sender, EventArgs e)
        {
            Response.Redirect("addassignment.aspx");
        }

        protected void assign_View(object sender, EventArgs e)
        {
            Response.Redirect("viewassignment.aspx");
        }

        protected void assign_Grade(object sender, EventArgs e)
        {
            Response.Redirect("gradeassignment.aspx");
        }


        protected void view_feed(object sender, EventArgs e)
        {
            Response.Redirect("viewmyfeedback.aspx");        
        }

        protected void issue_cer(object sender, EventArgs e)
        {
            Response.Redirect("issuecertificate.aspx");
        }
    }
}