using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class WhileEx
    {
        public void run()
        {
            int sum = 0;
            int number = 1;

            while (number <= 10)
            {
                sum += number;

                number++;
            }

            Console.WriteLine("1부터 10까지의 합 {0}", sum);
        }
    }
}
