using static System.Console;
using static System.DateTime;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class StaticUsing02
    {
        public void run()
        {
            Write("[현재시각 : {0}] 문장입력 : ", Now);
            dynamic word = ReadLine();
            WriteLine("{0}", word);
        }
    }
}