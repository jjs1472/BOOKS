using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrInsert01
    {
        public void run()
        {
            string strMsg = "My name Dexter";

            Console.WriteLine(strMsg);
            Console.WriteLine(strMsg.Insert(8, "is "));
        }
    }
}