using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class ForEx1
    {
        public void run()
        {
            int sum = 0;

            for (int idx = 1; idx <= 10; idx++)
            {
                sum += idx;
            }

            Console.WriteLine("1 ~ 10 까지의 합 : {0}", sum);
        }
    }
}
