using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class CalcSum
    {
        public void run()
        {
            int number1 = 0;
            int number2 = 0;

            Console.Write("첫 번째 숫자를 입력해주세요 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력해주세요 : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine("결과 값 : {0}", result);
        }
    }
}
