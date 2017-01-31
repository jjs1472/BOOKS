using static System.Console;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class IndexInit01
    {
        public void run()
        {
            var dict01 = new Dictionary<string, string>
            {
                ["a"] = "apple",
                ["b"] = "banana",
                ["c"] = "candy"
            };

            WriteLine(dict01["a"]);
            WriteLine(dict01["b"]);
            WriteLine(dict01["c"]);

            var dict02 = new Dictionary<int, string>
            {
                [0] = "zero",
                [1] = "one"
            };

            WriteLine(dict02[0]);
            WriteLine(dict02[1]);
        }
    }
}