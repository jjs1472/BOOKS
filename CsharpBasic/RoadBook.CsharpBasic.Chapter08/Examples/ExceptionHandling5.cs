using System;
using RoadBook.CsharpBasic.Chapter08.Examples.UserExcept;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class ExceptionHandling5
    {
        public void run()
        {
            Console.Write("두개의 숫자를 입력 하세요 : ");

            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Divide(number1, number2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new MyStyleException("0으로 나눌수 없습니다!!");
            }

            return number1 / number2;
        }
    }
}
