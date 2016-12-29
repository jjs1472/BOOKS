using System;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Error1
    {
        public void run()
        {
            Console.Write("숫자를 입력 하세요 : ");

            // 문자 입력 시 에러 발생
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("입력 된 숫자는 {0}", number);
        }
    }
}
