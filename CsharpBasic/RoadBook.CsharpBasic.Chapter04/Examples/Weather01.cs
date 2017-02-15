namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Weather01
    {
        public void run()
        {
            string day1 = "sunny";
            string day2 = "sunny";
            string day3 = "rainy";
            string day4 = "cloudy";
            string day5 = "rainy";
            string day6 = "snow";
            string day7 = "sunny";

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            if (day1 == "sunny")
            {
                sunnyCnt++;
            }
            else if (day1 == "cloudy")
            {
                cloudyCnt++;
            }
            else if (day1 == "rainy")
            {
                rainyCnt++;
            }
            else if (day1 == "snow")
            {
                snowCnt++;
            }

            //... if statemet 2 ... //
            //... if statemet 3 ... //
            //... if statemet 4 ... //
            //... if statemet 5 ... //
            //... if statemet 6 ... //

            if (day7 == "sunny")
            {
                sunnyCnt++;
            }
            else if (day7 == "cloudy")
            {
                cloudyCnt++;
            }
            else if (day7 == "rainy")
            {
                rainyCnt++;
            }
            else if (day7 == "snow")
            {
                snowCnt++;
            }

        }
    }
}
