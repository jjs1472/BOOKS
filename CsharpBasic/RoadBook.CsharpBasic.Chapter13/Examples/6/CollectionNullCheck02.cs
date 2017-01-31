using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class CollectionNullCheck02
    {
        public void run()
        {
            Book book = null;

            Console.WriteLine(book?.title);
        }
    }
}