using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class FileHandle01
    {
        private const string _dirpath = "d:\\mydirectory";

        public void run()
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(_dirpath);

            if (dirInfo.Exists)
            {
                for (int idx = 0; idx < 3; idx++)
                {
                    string filename = string.Format("{0}\\file{1}.txt", _dirpath, idx);

                    System.IO.File.Create(filename);
                }
            }

            foreach (var item in dirInfo.GetFiles())
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
