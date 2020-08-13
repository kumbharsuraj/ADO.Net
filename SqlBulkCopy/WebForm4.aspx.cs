using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace SqlBulkCopy1


{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string SourceDB = ConfigurationManager.ConnectionStrings["SourceDB"].ConnectionString;

            string DestinationDB = ConfigurationManager.ConnectionStrings["DestinationDB"].ConnectionString;
            using (SqlConnection SourceCon = new SqlConnection(SourceDB))
            {
                SqlCommand cmd1 = new SqlCommand("select *from Employee", SourceCon);
                SourceCon.Open();

                SqlDataReader reader = cmd1.ExecuteReader();

                using (SqlConnection DestinationCon = new SqlConnection(DestinationDB))
                {
             SqlBulkCopy 
                }

            }
         }
    }
}