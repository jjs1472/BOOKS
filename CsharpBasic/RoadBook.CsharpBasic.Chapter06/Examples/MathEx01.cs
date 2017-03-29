using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class MathEx01
    {
        public void run()
        {
            double pie = 3.141592;

            // 소수점 둘째자리까지 반올림
            Console.WriteLine(Math.Round(pie, 2));
            // 소수점 올림
            Console.WriteLine(Math.Ceiling(pie));
            // 소수점 내림
            Console.WriteLine(Math.Truncate(pie));
            // 절대값
            Console.WriteLine(Math.Abs(pie));
        }
    }
}