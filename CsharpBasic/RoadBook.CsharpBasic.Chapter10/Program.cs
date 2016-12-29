using System;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;
using RoadBook.CsharpBasic.Chapter10.Examples.Manager;
using System.Data;

namespace RoadBook.CsharpBasic.Chapter10
{
    class Program
    {
        private const string connectionStr = "Data Source=127.0.0.1,1433;Initial Catalog=testdb;User ID=sa;Password=test123!@#";

        static void Main(string[] args)
        {
            DBInfo dbInfo = new DBInfo();
            dbInfo.DBNAME = "testdb";
            dbInfo.IP = "127.0.0.1";
            dbInfo.PORT = 1433;
            dbInfo.USERID = "sa";
            dbInfo.USERPW = "test123!@#";

            MSSQLManager ms = new MSSQLManager();

            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendLine("******************************");
            sbMessage.AppendLine("1. SELECT");
            sbMessage.AppendLine("2. INSERT");
            sbMessage.AppendLine("3. UPDATE");
            sbMessage.AppendLine("4. DELETE");
            sbMessage.AppendLine("0. QUIT");
            sbMessage.AppendLine("******************************");

            while (true)
            {
                Console.WriteLine(sbMessage.ToString());
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("BYE!!");
                    break;
                }
                else
                {
                    string index = string.Empty;
                    string title = string.Empty;
                    string content = string.Empty;
                    string writer = string.Empty;
                    string write_date = string.Empty;

                    StringBuilder sbSQL = new StringBuilder();

                    switch (input)
                    {
                        case "1":   // SELECT
                            ms.open(dbInfo);

                            DataTable dt = ms.select("SELECT IDX, TITLE, CONTENT, WRITER, WRITE_DATE FROM TB_BOARD");

                            if (dt.Rows.Count > 0)
                            {
                                string[] columns = new string[dt.Columns.Count];

                                for (int idx = 0; idx < dt.Columns.Count; idx++)
                                {
                                    columns[idx] = dt.Columns[idx].ToString();

                                    Console.Write(dt.Columns[idx] + "\t");
                                }

                                Console.WriteLine();

                                for (int idx = 0; idx < dt.Rows.Count; idx++)
                                {
                                    for (int idx_j = 0; idx_j < dt.Columns.Count; idx_j++)
                                    {
                                        Console.Write(dt.Rows[idx][columns[idx_j]] + "\t");
                                    }

                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Data!!");
                            }

                            ms.close();
                            break;
                        case "2":   // INSERT
                            ms.open(dbInfo);

                            Console.Write("IDX : ");
                            index = Console.ReadLine();
                            Console.Write("TITLE : ");
                            title = Console.ReadLine();
                            Console.Write("CONTENT : ");
                            content = Console.ReadLine();
                            Console.Write("WRITER : ");
                            writer = Console.ReadLine();

                            write_date = DateTime.Now.ToString("yyyy-MM-dd");


                            sbSQL.Append(" INSERT TB_BOARD (IDX, TITLE, CONTENT, WRITER, WRITE_DATE) ");
                            sbSQL.Append(" VALUES( ");
                            sbSQL.Append("'").Append(index).Append("'").Append(",");
                            sbSQL.Append("'").Append(title).Append("'").Append(",");
                            sbSQL.Append("'").Append(content).Append("'").Append(",");
                            sbSQL.Append("'").Append(writer).Append("'").Append(",");
                            sbSQL.Append("'").Append(write_date).Append("'");
                            sbSQL.Append(" ) ");

                            ms.insert(sbSQL.ToString());

                            ms.close();
                            break;
                        case "3":   // UPDATE
                            ms.open(dbInfo);

                            Console.Write("Changed IDX : ");
                            index = Console.ReadLine();
                            Console.Write("TITLE : ");
                            title = Console.ReadLine();
                            Console.Write("CONTENT : ");
                            content = Console.ReadLine();
                            Console.Write("WRITER : ");
                            writer = Console.ReadLine();

                            write_date = DateTime.Now.ToString("yyyy-MM-dd");

                            sbSQL.Append(" UPDATE TB_BOARD SET ");
                            sbSQL.Append(" TITLE = '").Append(title).Append("'").Append(",");
                            sbSQL.Append(" CONTENT = '").Append(content).Append("'").Append(",");
                            sbSQL.Append(" WRITER = '").Append(writer).Append("'").Append("");
                            sbSQL.Append(" WHERE ");
                            sbSQL.Append(" IDX = '").Append(index).Append("'");

                            ms.update(sbSQL.ToString());

                            ms.close();
                            break;
                        case "4":   // DELETE
                            ms.open(dbInfo);

                            Console.Write("DELETED IDX : ");
                            index = Console.ReadLine();

                            sbSQL.Append(" DELETE FROM TB_BOARD ");
                            sbSQL.Append(" WHERE ");
                            sbSQL.Append(" IDX = '").Append(index).Append("'");

                            ms.update(sbSQL.ToString());

                            ms.close();
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }
            }
        }
    }
}
