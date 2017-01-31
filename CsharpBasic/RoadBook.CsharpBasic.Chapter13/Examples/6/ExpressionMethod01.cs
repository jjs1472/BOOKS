using static System.Console;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class ExpressionMethod01
    {
        public void run() => WriteLine(sum(5,10));
        
        public int sum(int num1, int num2) => num1 + num2;
    }
}