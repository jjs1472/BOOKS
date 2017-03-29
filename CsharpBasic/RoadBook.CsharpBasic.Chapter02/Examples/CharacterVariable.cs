using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class CharacterVariable
    {
        public void run()
        {
            char ch = 'A';
            string strMessage = "Hello Csharp";

            Console.WriteLine(ch);
            Console.WriteLine("{0}{1}{2}{3}{4}", strMessage[0], strMessage[1], strMessage[2], strMessage[3], strMessage[4]);
            Console.WriteLine(strMessage);
        }
    }
}