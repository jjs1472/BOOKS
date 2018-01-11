using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter10.Web
{
    public partial class board : System.Web.UI.Page
    {
        private const string connectionStr = "Data Source=127.0.0.1,1433;Initial Catalog=testdb;User ID=sa;Password=test123";

        protected void Page_Load(object sender, EventArgs e)
        {
            string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                //-- 데이터 SELECT
                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    
                    GridView1.DataSource = reader;
                }
                GridView1.DataBind();
            }
        }
    }
}