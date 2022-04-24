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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin1(object sender, EventArgs e)
        {
            try
            {
                Label.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
              
                while (username.Text == "" || password.Text == "")
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                    Label.Text = "please enter your ID and password";
                    form1.Controls.Add(tag);
                    
                    return;
                     
                }


                int id = Int16.Parse(username.Text);


                String pass = password.Text;

                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));
                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;
                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString() == "1")
                {
                    Session["user"] = id;
                    Response.Write("hello");
                    if (type.Value.ToString() == "0")
                    {
                        Response.Redirect("instructorhome.aspx");
                    }
                    else if (type.Value.ToString() == "1")
                    {
                        Response.Redirect("admin home.aspx");

                    }
                    else if (type.Value.ToString() == "2")
                    {
                        Response.Redirect("studenthome.aspx");
                    }
                }
                else
                {
                    Label.Text = "ID or password incorrect";
                }
            }

            catch (Exception ex)
            {
                Label.Text = ex.Message;
                return;
            }
        }

        protected void register(object sender, EventArgs e)
        {  
            Response.Redirect("registration.aspx");
        }
    }
}