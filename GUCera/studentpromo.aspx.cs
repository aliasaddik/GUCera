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
    public partial class studentpromo : System.Web.UI.Page
    {
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label3.Text = err.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e) { 
         string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand promocodes = new SqlCommand("Select code from promocode", conn);
        SqlCommand students = new SqlCommand("Select s.id, firstname from student s inner join users u on s.id=u.id", conn);
            conn.Open();
          
            //System.Web.UI.HtmlControls.HtmlGenericControl div = new HtmlGenericControl("div");
           

            //div.ID = "tables";

            Label avpromo = new Label();
            avpromo.CssClass = "label";
            avpromo.Text = "Available Promocodes";
            form1.Controls.Add(avpromo);


            GridView grid1 = new GridView();
            grid1.CssClass = "rtable";//class for everything
            grid1.ID = "grid1";
            //grid1.Attributes.Add("class", "aclass");
            


            grid1.EmptyDataText = "No promocodes available";
            grid1.DataSource =promocodes.ExecuteReader();
            grid1.DataBind();
            form1.Controls.Add(grid1);
            conn.Close();

            conn.Open();
            Label student = new Label();
            student.CssClass = "label";
            student.Text = "Registered Students";
            form1.Controls.Add(student);

            GridView grid2 = new GridView();
          
            grid2.CssClass = "rtable";//class for everything
            grid2.ID = "grid2";
            //grid1.Attributes.Add("class", "aclass");
            grid2.EmptyDataText = "No students available";
            grid2.DataSource = students.ExecuteReader();
            grid2.DataBind();
            form1.Controls.Add(grid2);
            //form1.Controls.Add(div);
            conn.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand promocodes = new SqlCommand("Select code from promocode", conn);
                SqlCommand students = new SqlCommand("Select id,firstname from student inner join users", conn);
                int student = Int32.Parse(sid.Text);
                String promo = pid.Text;
                SqlCommand issuepromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
                issuepromo.CommandType = CommandType.StoredProcedure;
                issuepromo.Parameters.Add(new SqlParameter("@sid", student));
                issuepromo.Parameters.Add(new SqlParameter("@pid", promo));

                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                issuepromo.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex) {
                Label3.Text = ex.Message;
            

            }
            



        }
    }
}