using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Insert
    {
        private const string connectionStr = "Data Source=127.0.0.1,1433;Initial Catalog=testdb;User ID=sa;Password=test123";

        public void run()
        {
            string insertSQL = " INSERT INTO TB_USER ( ID, NAME, AGE, JOB ) VALUES ( 'U006', '유저6', '25', '테스터' ) ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                Console.WriteLine("데이터베이스 연결 시도...");
                connection.Open();
                Console.WriteLine("데이터베이스 연결 OK...");

                //-- 데이터 INSERT
                using (SqlCommand command = new SqlCommand(insertSQL, connection))
                {
                    int activeNumber = command.ExecuteNonQuery();

                    Console.WriteLine("영향 받은 데이터 : " + activeNumber);
                }
                //-- //데이터 INSERT

                Console.WriteLine("데이터베이스 연결 끊기 시도...");
                connection.Close();
                Console.WriteLine("데이터베이스 연결 끊기 OK...");
            }
        }
    }
}
