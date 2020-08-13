using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows;
namespace School_web_page
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("usp_InsertStudent29", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ParentName", txtParent.Text);
            cmd.Parameters.AddWithValue("@StudentName", txtStudent.Text);
            cmd.Parameters.AddWithValue("@EmailID", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@AddressH", txtAddress.Text);

            try
            {
                
                cmd.ExecuteNonQuery();
                Response.Write("Submitted Sucessfully");
              
            }
            catch (Exception)
            {
                Response.Write(" Not Submited");
                
            }
            finally
            {
                con.Close();
            }
           
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudentById();
        }
        void LoadStudentById()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("usp_GetStudentbyId", con);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EnquiryID", txtID.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtParent.Text = reader["ParentName"].ToString();
                txtStudent.Text = reader["StudentName"].ToString();
                txtEmail.Text = reader["EmailId"].ToString();
                txtContact.Text = reader["Contact"].ToString();
                txtAddress.Text = reader["AddressH"].ToString();
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("usp_UpdateStudent", con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EnquiryID", txtID.Text);
            cmd.Parameters.AddWithValue("@ParentName", txtParent.Text);
            cmd.Parameters.AddWithValue("@StudentName", txtStudent.Text);
            cmd.Parameters.AddWithValue("@EmailID", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@AddressH", txtAddress.Text);

            con.Open();
            cmd.ExecuteNonQuery();

        }
    }
}