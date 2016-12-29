using System;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class ExceptionHandling1
    {
        public void run()
        {
            Console.Write("숫자를 입력 하세요 : ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력 된 숫자는 {0}", number);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외 상황 발생");
            }
        }
    }
}