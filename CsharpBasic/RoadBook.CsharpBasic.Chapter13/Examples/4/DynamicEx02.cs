using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class DynamicEx02
    {
        public void run()
        {
            object objValue = "test";
            Console.WriteLine(objValue.GetType());
            objValue = 10.0d;
            Console.WriteLine(objValue.GetType());

            dynamic dValue = "test";
            Console.WriteLine(dValue.GetType());
            dValue = 10.0d;
            Console.WriteLine(dValue.GetType());

            int testValue = 10;
            Console.WriteLine("{0} + {1} = {2}", testValue, objValue, testValue + (double)objValue);

            Console.WriteLine("{0} + {1} = {2}", testValue, dValue, testValue + dValue);
        }
    }
}