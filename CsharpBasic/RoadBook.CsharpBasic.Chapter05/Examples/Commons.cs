using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Commons
    {
        public void run()
        {
            // 개발자 A씨가 만든 코드
            move();
            attack();
            evacuation();
        }

        public void run2()
        {
            // 개발자 B씨가 만든 코드
            defense();
            attack();
            move();
        }

        /// <summary>
        /// 캐릭터 이동
        /// </summary>
        public void move()
        {
            Console.WriteLine("캐릭터가 이동을 합니다.");
        }

        /// <summary>
        /// 캐릭터 공격
        /// </summary>
        public void attack()
        {
            Console.WriteLine("캐릭터가 공격을 합니다.");
        }

        /// <summary>
        /// 캐릭터 방어
        /// </summary>
        public void defense()
        {
            Console.WriteLine("캐릭터가 방어를 합니다.");
        }

        /// <summary>
        /// 캐릭터 대피
        /// </summary>
        public void evacuation()
        {
            Console.WriteLine("캐릭터가 대피합니다.");
        }

    }
}
