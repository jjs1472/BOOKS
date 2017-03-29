using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class ConvertEx
    {
        public void run()
        {
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber); // ①
            int parseNumber = Int32.Parse(strNumber);       // ②
        }
    }
}