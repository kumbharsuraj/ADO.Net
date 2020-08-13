using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _2_Assignment_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            //LoadEmployeeById();
        }
        void LoadEmployee()
        {
            // Windows Authentication :=>
            //string cs = "Data Source=DESKTOP-UFTC3CC\\SQLEXPRESS;database=SURAJ29;integrated Security=true";

            // Sqlsever Authentication:=>
            // string cs = "Data Source=DESKTOP-UFTC3CC\\SQLEXPRESS;database=SURAJ29;Id= ;Passward=";

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //   SqlCommand cmd = new SqlCommand("select student3.name as Student,trainer2.Name as Trainer from student3  join trainer2 on student3.trainerid = trainer2.id", con);

            SqlCommand cmd = new SqlCommand("select * from trainer2;select* from employee29", con);

            SqlDataReader reader = cmd.ExecuteReader();
            gvEmployee.DataSource = reader;
            gvEmployee.DataBind();

            while (reader.NextResult())
            {
                gvEmployee29.DataSource = reader;
                gvEmployee29.DataBind();
            }

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string command = "select * from trainer2 where Name='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(command, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            gvEmployee.DataSource = reader;
            gvEmployee.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_InsertEmployee", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName1.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            LoadEmployee();

        }

        void LoadEmployeeById()
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("usp_GetEmpoyeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee2> employees = new List<Employee2>();
            while (reader.Read())
            {
                Employee2 emp = new Employee2();
                emp.Id = (int)reader["id"];
                emp.Name = reader["Name"].ToString();
                emp.Gender = reader["Gender"].ToString();
                emp.Salary = (int)reader["Salary"];
                employees.Add(emp);
            }

            //while (reader.Read())
            //{
            //    txtName1.Text = reader["Name"].ToString();
            //    txtSalary.Text = reader["Salary"].ToString();
            //    txtGender.Text = reader["Gender"].ToString(); 
            //}

            gvEmployee29.DataSource = employees;
            gvEmployee29.DataBind();

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployeeById();
        }


        protected void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            UpdateEmployee(id, txtName1.Text, txtGender.Text, txtSalary.Text);
            LoadEmployee();

        }


        public void UpdateEmployee(int id, string Name, string Gender, string Salary)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_UpdateEmployee29", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            con.Open();

            cmd.ExecuteNonQuery();

        }
        public void ClearData()
        {
            txtId.Text = "";
            txtName1.Text = "";
            txtGender.Text = "";
            txtSalary.Text = "";

        }

        protected void btnDelet_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_DeleteEmployeeById", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@Name", txtName1.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender);
            cmd.Parameters.AddWithValue("@Salary", txtSalary);
            con.Open();
            cmd.ExecuteNonQuery();

            LoadEmployee();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}