using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class admin_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mobile_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmobile.aspx");
        }

        protected void allcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("allcourse.aspx");
        }

        protected void notyet_Click(object sender, EventArgs e)
        {
            Response.Redirect("notyet.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("promocode.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentpromo.aspx");
        }
    }
}