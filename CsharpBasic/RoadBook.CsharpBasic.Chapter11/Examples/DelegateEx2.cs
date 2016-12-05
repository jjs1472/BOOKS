using System;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class DelegateEx2
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
            RunCalc calc = delegate (int a, int b)
            {
                return a / b;
            };

            Console.WriteLine(calc(10, 2));
        }
    }
}
