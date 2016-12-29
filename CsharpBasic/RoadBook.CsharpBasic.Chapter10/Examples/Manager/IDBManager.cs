using System.Data;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter10.Examples.Manager
{
    public interface IDBManager
    {
        void open(DBInfo dbInfo);
        DataTable select(string sql);
        int insert(string sql);
        int update(string sql);
        int delete(string sql);
        void close();
    }
}
