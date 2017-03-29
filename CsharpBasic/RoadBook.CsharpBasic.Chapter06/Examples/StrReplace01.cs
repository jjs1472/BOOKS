using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrReplace01
    {
        public void run()
        {
            string strMsg = "Apple,Grape,Melon";

            Console.WriteLine(strMsg.Replace("Apple", "Banana"));
        }
    }
}