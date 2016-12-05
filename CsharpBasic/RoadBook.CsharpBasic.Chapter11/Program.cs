using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.DelegateEx1 del = new Examples.DelegateEx1();

            del.run();
        }
    }
}