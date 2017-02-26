using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class NameSpaceEx01
    {
        public void run()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

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