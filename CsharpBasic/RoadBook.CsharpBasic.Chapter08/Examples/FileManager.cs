using System.IO;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class FileManager
    {
        private string _filepath;
        private StreamReader _sr;

        public FileManager(string filepath)
        {
            _filepath = filepath;
        }

        public string ReadFile()
        {
            FileInfo fi = new FileInfo(_filepath);

            if (!fi.Exists)
            {
                throw new FileNotFoundException();
            }
            else
            {
                _sr = new StreamReader(_filepath);

                StringBuilder sb = new StringBuilder();

                while (_sr.Peek() >= 0)
                {
                    sb.AppendLine(_sr.ReadLine());
                }

                return sb.ToString();
            }
        }

        public void ResourceClose()
        {
            if (_sr != null)
            {
                _sr.Close();
            }
        }
    }
}
