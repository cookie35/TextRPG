using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요.");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("");
            Console.WriteLine("원하는 행동을 입력하세요.");
            int action = int.Parse(Console.ReadLine());

            if(action == 0 || action > 3)
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("다시 원하는 행동을 입력하세요.");
                action = int.Parse(Console.ReadLine());

            }

            else
            {
                Console.WriteLine("예.");
            }

        }

    }
}

// 스파르타 마을에 오신 여러분 환영합니다.
// 이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.

// 1. 상태 보기
// 2. 인벤토리
// 3. 상점

// 원하시는 행동을 입력해주세요.>>