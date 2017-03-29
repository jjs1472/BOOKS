using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class EnumEx
    {
        public enum Location { Seoul, Kwangju, Busan };

        public void run()
        {
            Location loc = Location.Seoul;

            Console.WriteLine("Seoul Code : {0}", (int)loc);
        }
    }
}