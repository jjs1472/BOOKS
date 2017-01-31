using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class PLinqEx01
    {
        public void run()
        {
            var lst = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            lst.AsParallel().ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}