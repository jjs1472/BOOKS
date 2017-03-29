using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class DirectoryHandle02
    {
        private const string _dirpath = "d:\\mydirectory";

        public void run()
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(_dirpath);

            if (dirInfo.Exists)
            {
                for (int idx = 0; idx < 3; idx++)
                {
                    string subDirectoryPath = _dirpath + "\\" + idx;

                    System.IO.Directory.CreateDirectory(subDirectoryPath);
                }
            }

            foreach (var item in dirInfo.GetDirectories())
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}