using System;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class UsingEx01
    {
        public void run()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("*");
            sb.AppendLine("**");
            sb.AppendLine("***");
            sb.AppendLine("****");
            sb.AppendLine("***");
            sb.AppendLine("**");
            sb.AppendLine("*");

            Console.WriteLine(sb.ToString());
        }
    }
}