using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class ArrayListEx3
    {
        public void run()
        {
            ArrayList array = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                array.Add(idx);
            }

            for (int idx = 10; idx < 15; idx++)
            {
                array.Add(idx.ToString());
            }

            array.Insert(5, "100");

            for (int idx = 0; idx < array.Count; idx++)
            {
                Console.WriteLine(array[idx]);
            }

            //코드추가
            array.RemoveAt(5);

            for (int idx = 0; idx < array.Count; idx++)
            {
                Console.WriteLine(array[idx]);
            }
        }
    }
}
