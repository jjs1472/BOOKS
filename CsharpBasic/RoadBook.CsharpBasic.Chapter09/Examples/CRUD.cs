using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class CRUD
    {
        private const string connectionStr = "Data Source=127.0.0.1,1433;Initial Catalog=testdb;User ID=sa;Password=test123";

        public void run()
        {
            // INSERT문
            string insertSQL = " INSERT INTO TB_USER ( ID, NAME, AGE, JOB ) VALUES ( 'U006', '유저6', '25', '테스터' ) ";
            // UPDATE문
            string updateSQL = " UPDATE TB_USER SET NAME='코딩의신' WHERE ID='U003' ";
            // DELETE문
            string deleteSQL = " DELETE FROM TB_USER WHERE ID='U004' ";
            // SELECT문
            string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                Console.WriteLine("데이터베이스 연결 시도...");
                connection.Open();
                Console.WriteLine("데이터베이스 연결 OK...");

                int activeCount = 0;
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    Console.WriteLine("=== INSERT ===");
                    command.CommandText = insertSQL;
                    activeCount = command.ExecuteNonQuery();
                    Console.WriteLine(activeCount + "개 영향받음");

                    Console.WriteLine("=== UPDATE ===");
                    command.CommandText = updateSQL;
                    activeCount = command.ExecuteNonQuery();
                    Console.WriteLine(activeCount + "개 영향받음");

                    Console.WriteLine("=== DELETE ===");
                    command.CommandText = deleteSQL;
                    activeCount = command.ExecuteNonQuery();
                    Console.WriteLine(activeCount + "개 영향받음");

                    Console.WriteLine("=== SELECT ===");
                    command.CommandText = selectSQL;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ID"] + "/" + reader["NAME"] + "/" + reader["AGE"] + "/" + reader["JOB"]);
                    }
                }

                Console.WriteLine("데이터베이스 연결 끊기 시도...");
                connection.Close();
                Console.WriteLine("데이터베이스 연결 끊기 OK...");
            }
        }
    }
}
