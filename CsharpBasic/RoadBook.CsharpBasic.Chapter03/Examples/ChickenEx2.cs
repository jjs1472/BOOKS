using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class ChickenEx2
    {
        public void run()
        {
            Console.WriteLine("===== 직업선택 =====");
            Console.WriteLine("1. 프로그래머");
            Console.WriteLine("2. 의사");
            Console.WriteLine("3. 간호사");
            Console.WriteLine("4. 학생");
            Console.WriteLine("5. 그외");

            Console.WriteLine();
            Console.Write("직업이 무엇입니까?");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("바베큐치킨과 맥주를 서비스로 드립니다.");
            }
            else if (number == 2 || number == 3)
            {
                Console.WriteLine("치킨 샐러드를 서비스로 드립니다.");
            }
            else if (number == 4)
            {
                Console.WriteLine("양념치킨을 서비스로 드립니다.");
            }
            else
            {
                Console.WriteLine("프라이드치킨을 서비스로 드립니다.");
            }
        }
    }
}
