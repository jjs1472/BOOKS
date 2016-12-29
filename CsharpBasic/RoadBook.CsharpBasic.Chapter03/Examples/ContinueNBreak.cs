using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class ContinueNBreak
    {
        public void run()
        {
            int sum = 0;

            for (int idx = 0; idx < 20; idx++)
            {
                if (idx % 2 == 0)
                {
                    continue;
                }

                if (idx > 9)
                {
                    break;
                }

                sum += idx;
            }

            Console.WriteLine("9 이하의 홀수 합 : {0}", sum);
        }
    }
}
