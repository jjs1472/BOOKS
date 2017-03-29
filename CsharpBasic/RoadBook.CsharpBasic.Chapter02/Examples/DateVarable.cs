using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class DateVarable
    {
        public void run()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            string strToday = DateTime.Today.ToString();

            Console.WriteLine("{0}-{1}-{2}", year, month, day);
            Console.WriteLine(strToday);
        }
    }
}