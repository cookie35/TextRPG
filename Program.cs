using System;
using System.Security.Cryptography.X509Certificates;

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

            Intro();



            //처음 나올 페이지
            void Intro()
            {
                Console.WriteLine("");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("");
                Console.WriteLine("원하는 행동을 입력하세요.");
                int action = int.Parse(Console.ReadLine());
                
                Repeat(action);
                

            }


            void Repeat(int num)
            {
                Console.Clear();
                if (num == 0 || num > 3)
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("");
                    Intro();
                }

                else if (num == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("상태 보기");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                    Console.WriteLine("");
                    Console.WriteLine("Lv. 01");
                    Console.WriteLine("Chad ( 전사 )");
                    Console.WriteLine("공격력 : 10");
                    Console.WriteLine("방어력: 5");
                    Console.WriteLine("체 력 : 100");
                    Console.WriteLine("Gold: 1500 G");
                    Console.WriteLine("");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine("");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    int repeatNum = int.Parse(Console.ReadLine());
                    Menu(repeatNum);


                }

                else if (num == 2)
                {
                    inventory();

                }

            }
         
            
            void Menu(int Menunum)
            {
                if (Menunum == 0)
                {
                    Intro();
                }

                else
                {
                    ReEnter();
                }

            }

            void ReEnter()
            {

                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("");
                int againNum = int.Parse(Console.ReadLine());
                Menu(againNum);

            }


            void inventory()
            {
                Console.WriteLine("");
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("1.장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                int invenNum = int.Parse(Console.ReadLine());
                inven(invenNum);
            }


            void inven(int invenNum)
            {
                if (invenNum == 0)
                {
                    Intro();
                }

                else if (invenNum == 1)
                {
                    Manage();
                }

                else
                {
                    reEnter2();
                }

            }

            
            void reEnter2()
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("");
                int repetNum2 = int.Parse(Console.ReadLine());
                inven(repetNum2);
            }

            // 장착 관리 페이지
            void Manage()
            {
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("");
                Console.WriteLine("- 1 무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                Console.WriteLine("- 2 스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
                Console.WriteLine("- 3 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
                Console.WriteLine("");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                int manageNum = int.Parse(Console.ReadLine());
                Manage2(manageNum);

            }


            void Manage2(int manageNum)
            {
                if (manageNum == 0)
                {
                    inventory();
                    
                }

                else if (manageNum == 1)
                {

                }

                else if (manageNum == 2)
                {

                }

                else if (manageNum == 3)
                {

                }

                else
                {

                }


            }




        }

    }
}
