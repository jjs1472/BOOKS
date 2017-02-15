using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Weather02
    {
        public void run()
        {
            string days = "sunny,sunny,rainy,cloudy,rainy,snow,sunny";

            string[] arrDays = days.Split(',');

            Console.WriteLine(arrDays);
        }
    }
}