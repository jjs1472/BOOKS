using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class CollectionNullCheck01
    {
        public void run()
        {
            Book book = null;

            Console.WriteLine(book.title);
        }
    }

    class Book
    {
        public int idx { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
