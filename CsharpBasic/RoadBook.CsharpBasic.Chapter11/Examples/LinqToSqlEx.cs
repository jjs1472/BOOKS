using System;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class LinqToSqlEx
    {
        public void run()
        {
            using (LinqProvider.UsersDataContext context = new LinqProvider.UsersDataContext())
            {
                var query = context.TB_USER.Select(u => u);

                foreach (LinqProvider.TB_USER item in query)
                {
                    Console.WriteLine(item.NAME);
                }
            }
        }
    }
}
