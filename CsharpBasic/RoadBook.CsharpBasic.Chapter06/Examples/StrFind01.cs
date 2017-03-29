using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrFind01
    {
        public void run()
        {
            string strMsg = "Apple,Grape,Melon";

            Console.WriteLine(strMsg.IndexOf("Grape"));
            Console.WriteLine(strMsg.StartsWith("Apple"));
        }
    }
}