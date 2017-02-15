using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Weather03
    {
        public void run()
        {
            // step1> 배열 선언
            string[] days = new string[7];

            // step2> 배열 초기 값 입력
            days[0] = "sunny";
            days[1] = "sunny";
            days[2] = "rainy";
            days[3] = "cloudy";
            days[4] = "rainy";
            days[5] = "snow";
            days[6] = "sunny";

            // step3> 배열 가져오기
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