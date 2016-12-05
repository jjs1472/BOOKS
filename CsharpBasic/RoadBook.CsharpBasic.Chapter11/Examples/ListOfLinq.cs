using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class ListOfLinq
    {
        public void run()
        {
            List<Student> studentList = new List<Student>{
                new Student() { s_id = "s001", s_name = "Dexter", grade=4, major="SoftWare" },
                new Student() { s_id = "s002", s_name = "Juana", grade=3, major="Design" },
                new Student() { s_id = "s003", s_name = "Jack", grade=4, major="SoftWare" },
                new Student() { s_id = "s004", s_name = "Dorothy", grade=2, major="Theater" },
                new Student() { s_id = "s005", s_name = "Jobs", grade=1, major="SoftWare" },
                new Student() { s_id = "s006", s_name = "Thomas", grade=1, major="Theater" },
                new Student() { s_id = "s007", s_name = "Sofia", grade=3, major="Advertisement" }
            };

            // 3학년인 학생을 출력하시오.
            var resultList = from s in studentList
                         where s.grade == 3
                         select s;

            foreach (var result in resultList)
            {
                Console.WriteLine(result.s_name);
            }
            //--

            // 고학년( 3~4학년 )인 학생의 숫자를 계산하시오.
            resultList = from s in studentList
                         where s.grade >= 3
                         select s;

            Console.WriteLine(resultList.Count());
            //--

            // 학년순으로 오름차순 출력하시오.
            resultList = from s in studentList
                         orderby s.grade
                         select s;

            foreach (var result in resultList)
            {
                Console.WriteLine("{0},{1}", result.grade, result.s_name);
            }

            // 각 전공별 학생 수를 출력하시오.
            var groups = from s in studentList
                        group s by s.major into grp
                        select new { major = grp.Key, cnt = grp.Count() };

            foreach (var group in groups)
            {
                Console.WriteLine("{0} : {1}", group.major, group.cnt);
            }
            //--
        }
    }
}
