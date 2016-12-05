using System;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class LambdaEx1
    {
        private delegate int RunCalc(int a, int b);
        
        public void run()
        {
            RunCalc calc = (a, b) => a + b;
            Console.WriteLine(calc(1, 2));

            calc = (a, b) => a * b;
            Console.WriteLine(calc(1, 2));
        }
    }
}
