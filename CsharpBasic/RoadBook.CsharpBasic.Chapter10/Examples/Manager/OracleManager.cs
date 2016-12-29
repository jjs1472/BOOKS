using System.Data;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter10.Examples.Manager
{
    public class OracleManager : IDBManager
    {
        public void open(DBInfo dbInfo)
        {
            //TODO
        }

        public DataTable select(string sql)
        {
            //TODO
            return new DataTable();
        }

        public int insert(string sql)
        {
            //TODO
            return 0;
        }

        public int update(string sql)
        {
            //TODO
            return 0;
        }

        public int delete(string sql)
        {
            //TODO
            return 0;
        }

        public void close()
        {
            //TODO
        }
    }
}
