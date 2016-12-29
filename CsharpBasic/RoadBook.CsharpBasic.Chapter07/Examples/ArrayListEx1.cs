using System.Collections;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class ArrayListEx1
    {
        public void run()
        {
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }

            for (int idx = 0; idx < 15; idx++)
            {
                aList.Add(idx.ToString());
            }
        }
    }
}