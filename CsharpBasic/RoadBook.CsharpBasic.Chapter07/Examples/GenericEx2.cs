using System;
using System.Collections.Generic;
using RoadBook.CsharpBasic.Chapter07.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class GenericEx2
    {
        public void run()
        {
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();
            student.student_id = "S001";
            student.name = "홍길동";
            student.department = "국어국문학과";
            student.grade = 1;
            student.age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(arrStudent[idx].student_id);
                Console.WriteLine(arrStudent[idx].name);
                Console.WriteLine(arrStudent[idx].department);
                Console.WriteLine(arrStudent[idx].grade);
                Console.WriteLine(arrStudent[idx].age);
            }
        }
    }
}
