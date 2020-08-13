using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CopyData
{
    public partial class BulkCopy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sourceDB = ConfigurationManager.ConnectionStrings["SourceDB"].ConnectionString;

                string DestinationDB = ConfigurationManager.ConnectionStrings["DestinationDB"].ConnectionString;

                using (SqlConnection Sourcecon = new SqlConnection(sourceDB))
                {
                    SqlCommand cmd1 = new SqlCommand("Select * from Employee", Sourcecon);
                    Sourcecon.Open();

                    SqlDataReader Reader = cmd1.ExecuteReader();

                    using (SqlConnection Destintioncon = new SqlConnection(DestinationDB))
                    {
                        SqlBulkCopy Bulk = new SqlBulkCopy(DestinationDB);

                        Bulk.DestinationTableName = "Employee";
                        Destintioncon.Open();
                        Bulk.WriteToServer(Reader);
                    }
                }
                lblStatus.InnerText = "Backup Successful.";
            }
            catch (Exception)
            {
                lblStatus.InnerText = "Error in Backup";
            }
        }
        
    }
    
}