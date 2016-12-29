using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Select
    {
        private const string connectionStr = "Data Source=127.0.0.1,1433;Initial Catalog=testdb;User ID=sa;Password=test123";

        public void run()
        {
            string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                Console.WriteLine("데이터베이스 연결 시도...");
                connection.Open();
                Console.WriteLine("데이터베이스 연결 OK...");

                //-- 데이터 SELECT
                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ID"] + "/" + reader["NAME"] + "/" + reader["AGE"] + "/" + reader["JOB"]);
                    }
                }
                //-- //데이터 SELECT

                Console.WriteLine("데이터베이스 연결 끊기 시도...");
                connection.Close();
                Console.WriteLine("데이터베이스 연결 끊기 OK...");
            }
        }
    }
}
