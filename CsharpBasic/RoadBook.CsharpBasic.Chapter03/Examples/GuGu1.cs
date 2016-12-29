using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class GuGu1
    {
        public void run()
        {
            for (int idx = 2; idx < 10; idx++)
            {
                Console.WriteLine("=== {0} 단 ===", idx);
                Console.WriteLine("{0} * {1} = {2}", idx, 1, idx * 1);
                Console.WriteLine("{0} * {1} = {2}", idx, 2, idx * 2);
                Console.WriteLine("{0} * {1} = {2}", idx, 3, idx * 3);
                Console.WriteLine("{0} * {1} = {2}", idx, 4, idx * 4);
                Console.WriteLine("{0} * {1} = {2}", idx, 5, idx * 5);
                Console.WriteLine("{0} * {1} = {2}", idx, 6, idx * 6);
                Console.WriteLine("{0} * {1} = {2}", idx, 7, idx * 7);
                Console.WriteLine("{0} * {1} = {2}", idx, 8, idx * 8);
                Console.WriteLine("{0} * {1} = {2}", idx, 9, idx * 9);
            }
        }
    }
}
