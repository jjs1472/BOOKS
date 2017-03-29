using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrTrim01
    {
        public void run()
        {
            string strMsg = "   ABCDEFG   ";

            Console.WriteLine(strMsg.Trim());
            Console.WriteLine(strMsg.TrimStart());
            Console.WriteLine(strMsg.TrimEnd());
        }
    }
}