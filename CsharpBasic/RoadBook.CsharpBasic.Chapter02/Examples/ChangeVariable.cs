namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class ChangeVariable
    {
        public void run()
        {
            int number = 10;
            double bigNumber = number;      // ①
            object objNumber = number;      // ①

            int number2 = (int)bigNumber;   // ②
            int number3 = (int)objNumber;   // ②
        }
    }
}