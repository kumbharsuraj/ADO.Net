using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace _1_Introduction
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        void LoadEmployee()
        {
            // Windows Authentication :=>
            // string cs = "Data Source=DESKTOP-UFTC3CC\\SQLEXPRESS;database=SURAJ29;integrated Security=true";

            // Sqlsever Authentication:=>
            // string cs = "Data Source=DESKTOP-UFTC3CC\\SQLEXPRESS;database=SURAJ29;Id= ;Passward=";

           string cs= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //   SqlCommand cmd = new SqlCommand("select student3.name as Student,trainer2.Name as Trainer from student3  join trainer2 on student3.trainerid = trainer2.id", con);

            SqlCommand cmd = new SqlCommand("select * from student3;select * from trainer2",con);

           SqlDataReader reader= cmd.ExecuteReader();
            gvEmployee.DataSource = reader;
            gvEmployee.DataBind();

            while(reader.NextResult())
            {
                gvStudent.DataSource = reader;
                gvStudent.DataBind();
            }
        }
    }
}