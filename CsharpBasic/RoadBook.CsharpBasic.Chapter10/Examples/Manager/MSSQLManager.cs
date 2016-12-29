using System.Data;
using System.Data.SqlClient;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter10.Examples.Manager
{
    public class MSSQLManager : IDBManager
    {
        string _connStr = string.Empty;
        StringBuilder sbSQL;

        SqlConnection connection = null;

        public void open(DBInfo dbInfo)
        {
            _connStr = string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4}",
                                    dbInfo.IP,
                                    dbInfo.PORT,
                                    dbInfo.DBNAME,
                                    dbInfo.USERID,
                                    dbInfo.USERPW);

            connection = new SqlConnection(_connStr);
            connection.Open();
        }

        public DataTable select(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for (int idx = 0; idx < reader.FieldCount; idx++)
                    {
                        dt.Columns.Add(new DataColumn(reader.GetName(idx)));
                    }

                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();

                        for (int idx = 0; idx < dt.Columns.Count; idx++)
                        {
                            row[dt.Columns[idx]] = reader[dt.Columns[idx].ColumnName];
                        }

                        dt.Rows.Add(row);
                    }
                }
            }

            return dt;
        }

        public int insert(string sql)
        {
            int activeNumber = 0;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }

            return activeNumber;
        }

        public int update(string sql)
        {
            int activeNumber = 0;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }

            return activeNumber;
        }

        public int delete(string sql)
        {
            int activeNumber = 0;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }

            return activeNumber;
        }

        public void close()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
