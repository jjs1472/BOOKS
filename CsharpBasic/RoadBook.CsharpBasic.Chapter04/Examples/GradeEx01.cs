using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class GradeEx01
    {
        public void run()
        {
            string[][] gradeOfStudent = { new string[] { "A", "B", "A" }, new string[] { "B", "B+", "A" } };

            for (int idx = 0; idx < gradeOfStudent.Length; idx++)
            {
                for (int idx_j = 0; idx_j < gradeOfStudent[idx].Length; idx_j++)
                {
                    Console.WriteLine(gradeOfStudent[idx][idx_j]);
                }
            }
        }
    }
}