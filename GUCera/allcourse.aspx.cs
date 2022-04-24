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
    public partial class allcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand showcourse = new SqlCommand("AdminViewAllCourses", conn);
            showcourse.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = showcourse.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                // Label name = new Label();
                //name.CssClass = "name";
                System.Web.UI.HtmlControls.HtmlGenericControl name = new HtmlGenericControl("h3");

                Label credithours = new Label();
                credithours.CssClass = "label";
                Label cprice = new Label();
                cprice.CssClass = "label";
                Label caccepted = new Label();
                caccepted.CssClass = "label";
                Label ccontent = new Label();
                ccontent.CssClass = "label";

                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                String creditHours = (rdr.GetInt32(rdr.GetOrdinal("creditHours"))).ToString();
                String price = (rdr.GetDecimal(rdr.GetOrdinal("price"))).ToString();
               


                if ( !rdr.IsDBNull(rdr.GetOrdinal("accepted")) )
                {
                    if ((rdr.GetBoolean(rdr.GetOrdinal("accepted"))).ToString() == "0")
                    {
                        String accepted = "not accepted";
                        caccepted.Text += " (the course is " + accepted+")";
                    }
                    else
                    {
                        String accepted = "  accepted";
                        caccepted.Text += " (the course is " + accepted+")";

                    }

                }
                else
                {
                    String accepted = "not accepted";
                    caccepted.Text += " (the course is " + accepted + ")";
                }


                name.InnerText =  courseName;
                credithours.Text = " credit hours:" + creditHours;
                cprice.Text= " price:" + price;

                if (!rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    String content = rdr.GetString(rdr.GetOrdinal("content"));
                    ccontent.Text += "  content:" + content;

                }
               
                div.Controls.Add(name);
                div.Controls.Add(new LiteralControl("<br />"));
                div.Controls.Add(credithours);
                div.Controls.Add(new LiteralControl("<br />"));
                div.Controls.Add(cprice);
                div.Controls.Add(new LiteralControl("<br />"));
                div.Controls.Add(caccepted);
                div.Controls.Add(new LiteralControl("<br />"));
                div.Controls.Add(ccontent);
                div.Controls.Add(new LiteralControl("<br />"));
                form1.Controls.Add(div);
            }

        }
    }
}