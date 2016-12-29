using System;

namespace RoadBook.CsharpBasic.Chapter08.Examples.UserExcept
{
    class MyStyleException : Exception
    {
        public MyStyleException()
        {
        }

        public MyStyleException(string message) : base(message)
        {
        }
    }
}
