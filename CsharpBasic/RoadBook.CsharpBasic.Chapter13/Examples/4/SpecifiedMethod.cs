using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class SpecifiedMethod
    {
        public void run()
        {
            Console.WriteLine(divide(10, 2));

            Console.WriteLine(divide(bigNumber: 10, smallNumber: 2));

            Console.WriteLine(divide(smallNumber: 2, bigNumber: 10));
        }

        private double divide(int bigNumber, int smallNumber)
        {
            return bigNumber / smallNumber;
        }
    }
}