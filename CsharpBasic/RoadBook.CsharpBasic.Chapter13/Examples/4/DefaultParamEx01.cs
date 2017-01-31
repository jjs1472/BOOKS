using System;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class DefaultParamEx01
    {
        public void run()
        {
            helloMsg("Dexter");
            helloMsg("Dexter", "Hi!! ");
        }

        private void helloMsg(string name, string greeting = "Hello, ")
        {
            Console.WriteLine("{0}, My Name is {1}", greeting, name);
        }
    }
}