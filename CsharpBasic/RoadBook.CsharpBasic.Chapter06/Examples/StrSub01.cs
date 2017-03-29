using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrSub01
    {
        public void run()
        {
            string strMsg = "Welcome To The CSharp's World";

            Console.WriteLine(strMsg.Substring(0, 5));
            Console.WriteLine(strMsg.Substring(5, 10));
            Console.WriteLine(strMsg.Substring(10));
        }
    }
}