using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StrSplit01
    {
        public void run()
        {
            string strMsg = "Dexter,Juana,Bree,Jeffrey,Jose,Minimi";

            string[] nameList = strMsg.Split(',');

            for (int idx = 0; idx < nameList.Length; idx++)
            {
                Console.WriteLine(nameList[idx]);
            }

        }
    }
}