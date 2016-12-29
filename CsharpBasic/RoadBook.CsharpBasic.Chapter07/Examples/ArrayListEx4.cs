using System;
using System.Collections;
using RoadBook.CsharpBasic.Chapter07.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class ArrayListEx4
    {
        public void run()
        {
            ArrayList arrStudent = new ArrayList();

            Student student = new Student();
            student.student_id = "S001";
            student.name = "홍길동";
            student.department = "국어국문학과";
            student.grade = 1;
            student.age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(((Student)arrStudent[idx]).student_id);
                Console.WriteLine(((Student)arrStudent[idx]).name);
                Console.WriteLine(((Student)arrStudent[idx]).department);
                Console.WriteLine(((Student)arrStudent[idx]).grade);
                Console.WriteLine(((Student)arrStudent[idx]).age);
            }
        }
    }
}
