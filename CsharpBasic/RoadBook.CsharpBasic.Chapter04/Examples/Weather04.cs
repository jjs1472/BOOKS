using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Weather04
    {
        public void run()
        {
            // step1> 배열 선언과 동시에 초기화
            string[] days = { "sunny", "sunny", "rainy", "cloudy", "rainy", "snow", "sunny" };

            // step2> 배열 가져오기
            int dayCnt = days.Length;

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            for (int idx = 0; idx < dayCnt; idx++)
            {
                string weather = days[idx];

                if (weather == "sunny")
                {
                    sunnyCnt++;
                }
                else if (weather == "cloudy")
                {
                    cloudyCnt++;
                }
                else if (weather == "rainy")
                {
                    rainyCnt++;
                }
                else if (weather == "snow")
                {
                    snowCnt++;
                }
            }

            Console.WriteLine("Sunny : {0} / Cloudy : {1} / Rainy : {2}, Snow : {3}", sunnyCnt, cloudyCnt, rainyCnt, snowCnt);
        }
    }
}