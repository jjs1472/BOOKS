using static System.Console;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class StringInterpolation02
    {
        public void run()
        {
            var lstNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            lstNumber.ForEach(n => WriteLine($"{n} 은 {(n % 2 == 0 ? "짝수" : "홀수" )}입니다"));
        }
    }
}