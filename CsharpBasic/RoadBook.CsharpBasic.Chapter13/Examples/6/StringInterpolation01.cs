using static System.Console;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class StringInterpolation01
    {
        public void run()
        {
            Student student = new Student();

            WriteLine($"{student.sid} / {student.sname} / {student.age} / {student.deptid}");
        }
    }
}