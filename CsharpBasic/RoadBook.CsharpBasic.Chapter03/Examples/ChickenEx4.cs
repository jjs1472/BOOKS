using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class ChickenEx4
    {
        public void run()
        {
            Console.Write("직업이 무엇입니까?");
            string yourJob = Console.ReadLine();
            
            switch (yourJob.ToLower())
            {
                case "programmer":
                    Console.WriteLine("바베큐치킨과 맥주를 서비스로 드립니다.");
                    break;
                case "doctor":
                case "nurse":
                    Console.WriteLine("치킨 샐러드를 서비스로 드립니다.");
                    break;
                case "teacher":
                case "student":
                    Console.WriteLine("양념치킨을 서비스로 드립니다.");
                    break;
                default:
                    Console.WriteLine("프라이드치킨을 서비스로 드립니다.");
                    break;
            }
        }

    }
}
