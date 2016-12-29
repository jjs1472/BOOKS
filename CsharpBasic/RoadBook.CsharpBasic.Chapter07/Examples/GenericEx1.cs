using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class GenericEx1
    {
        public void run()
        {
            List<int> lst = new List<int>();

            for (int idx = 0; idx < 10; idx++)
            {
                lst.Add(idx);
            }

            for (int idx = 10; idx < 15; idx++)
            {
                lst.Add(idx);
            }

            lst.Insert(5, 100);

            for (int idx = 0; idx < lst.Count; idx++)
            {
                Console.WriteLine(lst[idx]);
            }

            //코드추가
            lst.RemoveAt(5);

            for (int idx = 0; idx < lst.Count; idx++)
            {
                Console.WriteLine(lst[idx]);
            }
        }
    }
}
