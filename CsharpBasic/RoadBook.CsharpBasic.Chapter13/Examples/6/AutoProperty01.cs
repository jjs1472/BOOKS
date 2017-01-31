using static System.Console;

namespace RoadBook.CsharpBasic.Chapter13.Examples
{
    public class AutoProperty01
    {
        public void run()
        {
            Student student = new Student();

            WriteLine("{0} / {1} / {2} / {3}", student.sid, student.sname, student.age, student.deptid);
        }
    }

    class Student
    {
        public string sid { get; set; } = "S001";
        public string sname { get; set; } = "Dexter";
        public int age { get; set; } = 32;
        public string deptid { get; set; } = "D001";
    }
}