using System;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class DelegateChain
    {
        private delegate void RunCalc(int a, int b);

        private static void sum(int number1, int number2)
        {
            Console.WriteLine("SUM : {0}", number1 + number2);
        }

        private static void multiply(int number1, int number2)
        {
            Console.WriteLine("MULTI : {0}", number1 * number2);
        }

        private static void divide(int number1, int number2)
        {
            Console.WriteLine("DIV : {0}", number1 / number2);
        }

        public void run()
        {
            RunCalc calc = (RunCalc)Delegate.Combine(new RunCalc(sum), new RunCalc(multiply), new RunCalc(divide));

            calc(20, 4);
        }
    }
}
