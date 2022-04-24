using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace GUCera
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                SqlCommand profileProc = new SqlCommand("viewMyProfile", conn);
                profileProc.CommandType = CommandType.StoredProcedure;
                profileProc.Parameters.Add(new SqlParameter("@id", id));
                conn.Open();
                profileProc.ExecuteNonQuery();
                SqlDataReader sdr = profileProc.ExecuteReader();

                //List <string> data = new List <string>();

                while (sdr.Read())
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl sid = new HtmlGenericControl("h3");
                    sid.InnerText = "- ID : " + (Int32)sdr["id"];
                    form1.Controls.Add(sid);

                    System.Web.UI.HtmlControls.HtmlGenericControl fname = new HtmlGenericControl("h3");
                    fname.InnerText = "-First Name: " + (string)sdr["firstname"];
                    form1.Controls.Add(fname);

                    System.Web.UI.HtmlControls.HtmlGenericControl lname = new HtmlGenericControl("h3");
                    lname.InnerText = "-Last Name " + (string)sdr["lastname"];
                    form1.Controls.Add(lname);

                    System.Web.UI.HtmlControls.HtmlGenericControl password = new HtmlGenericControl("h3");
                    password.InnerText = "-Password: " + (string)sdr["password"];
                    form1.Controls.Add(password);

                    System.Web.UI.HtmlControls.HtmlGenericControl gender = new HtmlGenericControl("h3");
                    Byte[] genders = (byte[])sdr.GetSqlBinary(sdr.GetOrdinal("gender"));

                    if (genders[0] == 0)
                    {
                        gender.InnerText = "-Gender:female";

                    }
                    else
                    {
                        gender.InnerText = "-Gender: Male";
                    }
                    form1.Controls.Add(gender);

                    System.Web.UI.HtmlControls.HtmlGenericControl email = new HtmlGenericControl("h3");
                    email.InnerText = "-Email:" + sdr["email"];
                    form1.Controls.Add(email);

                    System.Web.UI.HtmlControls.HtmlGenericControl address = new HtmlGenericControl("h3");
                    address.InnerText = "-address: " + (string)sdr["address"];
                    form1.Controls.Add(address);

                    System.Web.UI.HtmlControls.HtmlGenericControl gpa = new HtmlGenericControl("h3");
                    gpa.InnerText = "-Cumilative GPA: " + sdr["gpa"];
                    form1.Controls.Add(gpa);






                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }



        }
    }
}