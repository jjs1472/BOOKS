using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class GenericDictEx
    {
        public void run()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("america", "미국");
            dic.Add("brazil", "브라질");
            dic.Add("japan", "일본");
            dic.Add("korea", "한국");
            dic.Add("spain", "스페인");

            while (true)
            {
                Console.Write("단어를 입력하세요(Q:종료) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (dic.ContainsKey(word))
                {
                    Console.WriteLine("{0} : {1}", word, dic[word]);

                    Console.Write("단어를 삭제할까요?(Y:삭제 / N:미삭제) : ");
                    string deleteYN = Console.ReadLine();

                    if (deleteYN.ToUpper() == "Y")
                    {
                        dic.Remove(word);
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

                        dic.Add(word, value);
                    }
                }
            }
        }
    }
}
