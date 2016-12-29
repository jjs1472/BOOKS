using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class GuGu2
    {
        public void run()
        {
            for (int idx_i = 2; idx_i < 10; idx_i++)
            {
                Console.WriteLine("=== {0} 단 ===", idx_i);

                for (int idx_j = 1; idx_j < 10; idx_j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", idx_i, idx_j, idx_i * idx_j);
                }
            }
        }
    }
}
