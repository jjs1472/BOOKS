using System;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class ExceptionHandling2
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
                Console.WriteLine("예외 상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("에러 코드 : {0}", e.HResult);
                Console.WriteLine("에러 메시지 : {0}", e.Message);
            }
        }
    }
}
