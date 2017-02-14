using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class DoWileEx
    {
        public void run()
        {
            int sum = 0;
            int number = 1;

            do
            {
                sum += number;

                number++;
            } while (number <= 10);

            Console.WriteLine(sum);
        }
    }
}
