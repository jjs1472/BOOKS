using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class HashtableEx2
    {
        public void run()
        {
            Hashtable hst = new Hashtable();
            hst.Add("america", "미국");
            hst.Add("brazil", "브라질");
            hst.Add("japan", "일본");
            hst.Add("korea", "한국");
            hst.Add("spain", "스페인");

            while (true)
            {
                Console.Write("단어를 입력하세요(Q:종료) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (hst.Contains(word))
                {
                    Console.WriteLine("{0} : {1}", word, hst[word]);

                    Console.Write("단어를 삭제할까요?(Y:삭제 / N:미삭제) : ");
                    string deleteYN = Console.ReadLine();

                    if (deleteYN.ToUpper() == "Y")
                    {
                        hst.Remove(word);
                    }
                }
                else
                {
                    Console.Write("단어 검색결과가 없습니다. 사전에 추가 할까요? (Y:추가 / N:미추가) : ");
                    string addYN = Console.ReadLine();

                    if (addYN.ToUpper() == "Y")
                    {
                        Console.Write("뜻을 입력하세요 : ");
                        string value = Console.ReadLine();

                        hst.Add(word, value);
                    }
                }
            }
        }
    }
}