using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class GenericQueueEx
    {
        public void run()
        {
            // Queue의 Generic 화
            Queue<string> que = new Queue<string>();

            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(idx + "번승객");
            }

            Console.WriteLine("=====정류장 승객 현황=====");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("==========================");
            Console.WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for (int i = 0; i < 6; i++)
            {
                que.Dequeue();
            }

            Console.WriteLine("버스가 출발했습니다. 한명의 승객이 추가가 되었습니다.");

            que.Enqueue("새로운승객");

            Console.WriteLine("=====정류장 승객 현황=====");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("==========================");
        }
    }
}
