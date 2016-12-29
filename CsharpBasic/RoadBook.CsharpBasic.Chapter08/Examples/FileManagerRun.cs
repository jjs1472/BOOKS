using System;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class FileManagerRun
    {
        public void run()
        {
            FileManager fManager = new FileManager("d:\\abc.txt");

            try
            {
                Console.WriteLine(fManager.ReadFile());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fManager.ResourceClose();
            }
        }
    }
}
