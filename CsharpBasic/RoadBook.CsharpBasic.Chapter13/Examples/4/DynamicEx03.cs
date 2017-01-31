using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class DynamicEx03
    {
        public void run()
        {
            dynamic dValue = new { Name = "Dexter", Age = 32 };

            Console.WriteLine(dValue.Name);
            Console.WriteLine(dValue.Age);
        }
    }
}