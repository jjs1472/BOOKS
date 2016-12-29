using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Error2
    {
        public void run()
        {
            List<string> strList = new List<string>();

            strList.Add("HI");

            Console.WriteLine(strList[0]);

            strList.Clear();

            //리스트 클리어 후 에러 발생
            Console.WriteLine(strList[0]);
        }
    }
}
