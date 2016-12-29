using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class GenericStackEx
    {
        public void run()
        {
            // Stack의 Generic 화
            Stack<string> stk = new Stack<string>();

            for (int idx = 1; idx < 11; idx++)
            {
                stk.Push(idx + "등선수");
            }

            Console.WriteLine("=====시 작 점=====");
            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("=====골    인=====");

            Console.WriteLine("5~10등 선수 탈락");

            for (int idx = 0; idx < 6; idx++)
            {
                stk.Pop();
            }

            Console.WriteLine("=====올림픽 참가권=====");
            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("=======================");
        }
    }
}
