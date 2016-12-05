using System;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    public class Calculator
    {
        public void run()
        {
            int number1 = 0;
            int number2 = 0;

            Console.Write("첫 번째 숫자를 입력해주세요 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력해주세요 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("더한 값 : {0}", number1 + number2);
            Console.WriteLine("뺀 값 : {0}", number1 - number2);
            Console.WriteLine("곱한 값 : {0}", number1 * number2);
            Console.WriteLine("나눈 값 : {0}", (double)number1 / (double)number2);
        }
    }
}
