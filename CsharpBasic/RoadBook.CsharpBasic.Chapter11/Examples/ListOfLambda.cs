using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter11.Examples
{
    public class ListOfLambda
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
            for (int idx = 0; idx < studentList.Count; idx++)
            {
                if (studentList[idx].grade == 3)
                {
                    Console.WriteLine(studentList[idx].s_name);
                }
            }

            studentList.Where(s => s.grade == 3)
                       .ToList()
                       .ForEach(s => Console.WriteLine(s.s_name));
            //--

            // 고학년( 3~4학년 )인 학생의 숫자를 계산하시오.
            int higherCount = 0;
            for (int idx = 0; idx < studentList.Count; idx++)
            {
                if (studentList[idx].grade >= 3)
                {
                    higherCount++;
                }
            }
            Console.WriteLine(higherCount);

            Console.WriteLine(studentList.Where(s => s.grade >= 3).Count());
            //--

            // 학년순으로 오름차순 출력하시오.
            studentList.OrderBy(s => s.grade)
                       .ToList()
                       .ForEach(s => Console.WriteLine("{0},{1}", s.grade, s.s_name));

            // 각 전공별 학생 수를 출력하시오.
            int softCnt = 0;
            int designCnt = 0;
            int theaterCnt = 0;
            int adCnt = 0;

            for (int idx = 0; idx < studentList.Count; idx++)
            {
                if (studentList[idx].major == "SoftWare")
                {
                    softCnt++;
                }
                else if (studentList[idx].major == "Design")
                {
                    designCnt++;
                }
                else if (studentList[idx].major == "Theater")
                {
                    theaterCnt++;
                }
                else if (studentList[idx].major == "Advertisement")
                {
                    adCnt++;
                }
            }

            Console.WriteLine("SoftWare : {0}", softCnt);
            Console.WriteLine("Design : {0}", designCnt);
            Console.WriteLine("Theater : {0}", theaterCnt);
            Console.WriteLine("Advertisement : {0}", adCnt);

            studentList.GroupBy(s => s.major, (key, g) => new { major = key, cnt = g.Count() })
                       .ToList()
                       .ForEach(s => Console.WriteLine("{0} : {1}", s.major, s.cnt));
            //--

            // 총점, 최고점수, 최저점수, 평균점수를 구하시오
            List<int> gradeList = new List<int>{ 100, 90, 75, 84, 92 };

            int sum = 0;
            int max = 0;
            int min = 100;
            double avg = 0;

            for (int idx = 0; idx < gradeList.Count; idx++)
            {
                int grade = gradeList[idx];

                sum += grade;

                if (max < grade)
                {
                    max = grade;
                }

                if (min > grade)
                {
                    min = grade;
                }
            }

            avg = sum / (double)gradeList.Count;
            Console.WriteLine("SUM : {0}", sum);
            Console.WriteLine("Max : {0}", max);
            Console.WriteLine("Min : {0}", min);
            Console.WriteLine("Avg : {0}", avg);

            Console.WriteLine("SUM : {0}", gradeList.Sum());
            Console.WriteLine("Max : {0}", gradeList.Max());
            Console.WriteLine("Min : {0}", gradeList.Min());
            Console.WriteLine("Avg : {0}", gradeList.Average());
            
        }
    }

    public class Student
    {
        /// <summary>
        /// 학번
        /// </summary>
        public string s_id { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public string s_name { get; set; }
        /// <summary>
        /// 학년
        /// </summary>
        public int grade { get; set; }
        /// <summary>
        /// 전공
        /// </summary>
        public string major { get; set; }
    }
}
