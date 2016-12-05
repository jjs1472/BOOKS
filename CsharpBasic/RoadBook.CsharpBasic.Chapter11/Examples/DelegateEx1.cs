using System;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class DelegateEx1
    {
        private delegate int RunCalc(int a, int b);

        private static int sum(int number1, int number2)
        {
            return number1 + number2;
        }

        private static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public void run()
        {
            RunCalc calc = sum;
            Console.WriteLine(calc(1, 2));
            calc = multiply;
            Console.WriteLine(calc(1, 2));
        }
    }
}
