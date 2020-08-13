using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace _3_SqlDataAdepter
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoaidTrainer();
        }

        void LoaidTrainer()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter adapter = new SqlDataAdapter("select * from trainer2;select* from employee29", con);
            DataSet ds = new DataSet ();
            adapter.Fill(ds);

            ds.Tables[0].TableName = "trainer2";
            ds.Tables[1].TableName = "employee29";

            gvEmployee.DataSource = ds.Tables["trainer2"];
            gvEmployee.DataBind();

            gvStudent.DataSource = ds.Tables["employee29"];
            gvStudent.DataBind();



        }
    }
}