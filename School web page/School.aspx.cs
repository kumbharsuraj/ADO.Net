using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace School_web_page
{
    public partial class School : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }
        void LoadStudent()
        {
            //string cs = "Data Source=DESKTOP-CGOF419;Initial Catalog=SURAJ29;Integrated Security=True;";
           string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from SchoolAdmitionEnquiry", con);
            
            SqlDataReader reader = cmd.ExecuteReader();
            gvStudent.DataSource = reader;
            gvStudent.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string command = "select * from SchoolAdmitionEnquiry where EnquiryID = " + txtId.Text;
            SqlCommand cmd = new SqlCommand(command, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            gvStudent.DataSource = reader;
            gvStudent.DataBind();
        }
    }
}