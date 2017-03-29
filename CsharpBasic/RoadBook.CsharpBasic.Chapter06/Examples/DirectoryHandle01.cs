using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class DirectoryHandle01
    {
        private const string _dirpath = "d:\\mydirectory";

        public void run()
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(_dirpath);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();

                Console.WriteLine("디렉토리 생성");
            }
        }
    }
}
