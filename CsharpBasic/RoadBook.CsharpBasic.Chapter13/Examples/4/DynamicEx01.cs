using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class DynamicEx01
    {
        public void run()
        {
            dynamic dValue = 10;
            Console.WriteLine(dValue.GetType());

            dValue = 0.5d;
            Console.WriteLine(dValue.GetType());

            dValue = "Hello Csharp";
            Console.WriteLine(dValue.GetType());

            //string str = "test";
            //str = 1;                // 컴파일 에러

            //var vValue = 10.0d;
            //Console.WriteLine(vValue.GetType());
            //vValue = 1;             // 에러는 아니지만, 여전히 double형
            //Console.WriteLine(vValue.GetType());
            //vValue = "10";          // 컴파일 에러
        }
    }
}