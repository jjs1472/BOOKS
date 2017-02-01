using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Variable_var
    {
        public void run()
        {
            var value01 = "1";
            Console.WriteLine("{0} : {1}", value01, value01.GetType());

            var value02 = 10.0d;
            Console.WriteLine("{0} : {1}", value02, value02.GetType());
        }
    }
}