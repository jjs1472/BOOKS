namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class StaticStringUtil
    {
        public static string Sub(string word, int startIdx, int length)
        {
            int wordCnt = word.Length - 1;
            int endIdx = startIdx + length;

            string tmpWord = string.Empty;

            if (wordCnt < startIdx)
            {
                tmpWord = "";
            }
            else if (wordCnt < endIdx)
            {
                tmpWord = word.Substring(startIdx);
            }
            else
            {
                tmpWord = word.Substring(startIdx, length);
            }

            return tmpWord;
        }

        public static bool isFindWord(string msg, string findWord)
        {
            bool isFind = false;

            if (msg.ToLower().IndexOf(findWord.ToLower()) < 0)
            {
                isFind = false;
            }
            else
            {
                isFind = true;
            }

            return isFind;
        }
    }
}