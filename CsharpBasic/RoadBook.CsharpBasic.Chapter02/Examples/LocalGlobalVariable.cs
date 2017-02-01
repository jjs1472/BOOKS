using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class LocalGlobalVariable
    {
        int globalValue = 20;

        public void run()
        {
            int localValue = 10;

            testMethod01();
            testMethod02();

            Console.WriteLine("local : {0} / global : {1}", localValue, globalValue);
        }

        public void testMethod01()
        {
            globalValue = globalValue + 10;
        }

        public void testMethod02()
        {
            globalValue = globalValue + 1;
        }
    }
}