using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class MathRun01
    {
        public void run()
        {
            MyMath01 mMath = new MyMath01();

            int number1 = 10;
            int number2 = 7;

            // 두 수를 메소드에 넘겨주고, 해당 메소드에서 계산을 한 값을 받는다.
            Console.WriteLine(mMath.sum(number1, number2));
            Console.WriteLine(mMath.minus(number1, number2));
        }
    }
}