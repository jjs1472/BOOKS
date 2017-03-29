using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class ExceptionEx01
    {
        public void run()
        {
            string strMsg = "My Love Csharp";

            try
            {
                Console.WriteLine(strMsg.Substring(10, 20));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}