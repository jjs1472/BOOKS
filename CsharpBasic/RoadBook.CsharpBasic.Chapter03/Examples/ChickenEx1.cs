using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class ChickenEx1
    {
        public void run()
        {
            Console.WriteLine("===== 주문 =====");
            Console.WriteLine("1. 프라이드치킨");
            Console.WriteLine("2. 감자칩");
            Console.WriteLine();
            Console.Write("무엇을 주문하시겠습니까?");
            string strNumber = Console.ReadLine();

            if (Convert.ToInt32(strNumber) == 1)
            {
                Console.WriteLine("치킨 한마리를 추가로 드립니다.");
            }
            else
            {
                Console.WriteLine("10% 할인하여 드립니다.");
            }
        }
    }
}
