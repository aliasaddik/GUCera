using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class studenthome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mobile_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmobile.aspx");
        }

        

        protected void viewAssign_click(object sender, EventArgs e)
        {
            Response.Redirect("assignments.aspx");
        }

        protected void submitAssign_Click(object sender, EventArgs e)
        {
             Response.Redirect("assignmentSubmission.aspx");
        }

        

        protected void viewGrades_Click(object sender, EventArgs e)
        {
            Response.Redirect("grades.aspx");
        }

        protected void feedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("feedback.aspx");
        }

        protected void certificates_Click(object sender, EventArgs e)
        {
            Response.Redirect("certificates.aspx");

        }
        protected void viewProfile(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
        protected void viewCourses(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }
        protected void addCard(object sender, EventArgs e)
        {
            Response.Redirect("addCreditCard.aspx");
        }
        protected void viewPromocodes(object sender, EventArgs e)
        {
            Response.Redirect("promocodes.aspx");
        }
    }
}