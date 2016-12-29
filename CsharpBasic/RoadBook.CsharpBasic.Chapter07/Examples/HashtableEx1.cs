using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class HashtableEx1
    {
        public void run()
        {
            Hashtable hst = new Hashtable();
            hst.Add("America", "미국");
            hst.Add("Brazil", "브라질");
            hst.Add("Japan", "일본");
            hst.Add("Korea", "한국");
            hst.Add("Spain", "스페인");

            Console.Write("단어를 입력하세요 : ");
            string word = Console.ReadLine();

            if (hst.Contains(word))
            {
                Console.WriteLine("{0} : {1}", word, hst[word]);
            }
            else
            {
                Console.WriteLine("단어 검색결과가 없습니다.");
            }
        }
    }
}
