using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class coursePage : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label1.Text = err.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = (string)Session["courseName"];
                int cid = (int)Session["courseID"];
                int sid = (int)Session["user"];
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand infoProc = new SqlCommand("courseInformation", conn);
                infoProc.CommandType = CommandType.StoredProcedure;

                infoProc.Parameters.Add(new SqlParameter("@id", cid));
                conn.Open();
                infoProc.ExecuteNonQuery();
                SqlDataReader rdr = infoProc.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl div = new HtmlGenericControl("div");


                    System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h1");
                    tag.InnerText = name;
                    div.Controls.Add(tag);
                    System.Web.UI.HtmlControls.HtmlGenericControl courseid = new HtmlGenericControl("h3");
                    courseid.InnerText = "Course ID:" + rdr["id"].ToString();
                    div.Controls.Add(courseid);
                    System.Web.UI.HtmlControls.HtmlGenericControl credit = new HtmlGenericControl("h3");
                    credit.InnerText = "Credit Hours:" + rdr["creditHours"].ToString();
                    div.Controls.Add(credit);
                    System.Web.UI.HtmlControls.HtmlGenericControl description = new HtmlGenericControl("h3");
                    if (rdr["courseDescription"] == DBNull.Value)
                    {
                        description.InnerText = "Course Description: not yet specified";
                    }
                    else
                    {
                        description.InnerText = "Course Description:" + rdr["courseDescription"];
                    }
                    div.Controls.Add(description);
                    System.Web.UI.HtmlControls.HtmlGenericControl price = new HtmlGenericControl("h3");
                    if (rdr["price"] == DBNull.Value)
                    {
                        price.InnerText = "Price: not yet specified";
                    }
                    else
                    {
                        price.InnerText = "price:" + rdr["price"];
                    }
                    div.Controls.Add(price);

                    System.Web.UI.HtmlControls.HtmlGenericControl content = new HtmlGenericControl("h3");
                    if (rdr["content"] == DBNull.Value)
                    {
                        content.InnerText = "Content: not yet specified";
                    }
                    else
                    {
                        content.InnerText = "Content:" + rdr["content"];
                    }
                    div.Controls.Add(content);
                    System.Web.UI.HtmlControls.HtmlGenericControl admin = new HtmlGenericControl("h3");
                    if (rdr["adminID"] == DBNull.Value)
                    {
                        admin.InnerText = "Admin ID : not yet specified";
                    }
                    else
                    {
                        admin.InnerText = "Admin ID:" + rdr["adminID"];
                    }
                    div.Controls.Add(admin);
                    System.Web.UI.HtmlControls.HtmlGenericControl inst = new HtmlGenericControl("h3");
                    if (rdr["instructorId"] == DBNull.Value)
                    {
                        inst.InnerText = "Instructor ID: not yet specified";
                    }
                    else
                    {
                        inst.InnerText = "Instructor ID:" + rdr["instructorId"];
                    }
                    div.Controls.Add(inst);


                    courseInfo.Controls.Add(div);





                    Button btn = new Button();
                    btn.CssClass = "button";
                    btn.Text = "Enroll";
                    btn.Click += new EventHandler(click);
                    form1.Controls.Add(btn);

                    



                }
                conn.Close();

                int courseID = (int)Session["courseID"];
                SqlCommand instructors = new SqlCommand("SELECT I.insid as InstructorsID, U.firstName as Name FROM InstructorTeachCourse I inner join users u on u.id=I.insid  where cid= @id ", conn);
                instructors.Parameters.Add(new SqlParameter("@id", courseID));

                conn.Open();
                GridView grid1 = new GridView();
                grid1.CssClass = "rtable";//class for everything
                grid1.ID = "grid1";
                //grid1.Attributes.Add("class", "aclass");

                grid1.EmptyDataText = "No other Instructors available";
                grid1.DataSource = instructors.ExecuteReader();
                grid1.DataBind();
                form1.Controls.Add(grid1);
                conn.Close();
            }
            catch(Exception ex)

            {
                Response.Write(ex.Message);

            }
          

        }
        protected void click(object sender, EventArgs e) {
          
            try
            {
                Label1.Text = "";
                int cid = (int)Session["courseID"];
                int sid = (int)Session["user"];
                String insid = input.Text;
                

                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
                enroll.CommandType = CommandType.StoredProcedure;
                enroll.Parameters.Add(new SqlParameter("@sid", sid));
                enroll.Parameters.Add(new SqlParameter("@cid", cid));
                enroll.Parameters.Add(new SqlParameter("@instr", insid));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                enroll.ExecuteNonQuery();
                conn.Close();
               

            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }



    }
}