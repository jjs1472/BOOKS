using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class GradeCalc01
    {
        public void run()
        {
            int mid, fin;

            Console.Write("중간고사 점수 : ");
            mid = Convert.ToInt32(Console.ReadLine());
            Console.Write("기말고사 점수 : ");
            fin = Convert.ToInt32(Console.ReadLine());

            if (mid > 100 || mid < 0)
            {
                Console.WriteLine("에러! 중간고사 점수는 0 ~ 100 까지 입력할 수 있습니다.");
            }
            else if (fin > 100 || fin < 0)
            {
                Console.WriteLine("에러! 기말고사 점수는 0 ~ 100 까지 입력할 수 있습니다.");
            }
            else
            {
                double avg = (double)(mid + fin) / 2.0;

                if (avg >= 90)
                {
                    Console.WriteLine("학점 : A");
                }
                else if (avg >= 80 && avg < 890)
                {
                    Console.WriteLine("학점 : B");
                }
                else if (avg >= 70 && avg < 80)
                {
                    Console.WriteLine("학점 : C");
                }
                else if (avg >= 60 && avg < 70)
                {
                    Console.WriteLine("학점 : D");
                }
                else
                {
                    Console.WriteLine("학점 : F");
                }
            }
        }
    }
}
