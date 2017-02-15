using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class ArrayEx01
    {
        public void run()
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("arr1");
            arrList.Add("arr2");
            //.
            //.
            arrList.Add("arr8");

            int arrCnt = arrList.Count;

            for (int idx = 0; idx < arrCnt; idx++)
            {
                Console.WriteLine(arrList[idx]);
            }
        }
    }
}