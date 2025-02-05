using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string metalArmor = "- 1. 무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.";
            string metalArmorEquip = "- 1. [E] 무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.";
            string spear = "- 2. 스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.";
            string spearEquip = "- 2. [E] 스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.";
            string oldsword = "- 3. 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.";
            string oldswordEquip = "- 3. [E] 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.";
            string item1notbuy = "- 1 수련자 갑옷 | 방어력 + 5 | 수련에 도움을 주는 갑옷입니다.             |  1000 G";
            string item1buy = "- 1 수련자 갑옷 | 방어력 + 5 | 수련에 도움을 주는 갑옷입니다.             |  구매완료";
            string item2notbuy = "- 2 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  2000 G";
            string item2buy = "- 2 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료";
            string item3notbuy = "- 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G";
            string item3buy = "- 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  구매완료";
            string item4notbuy = "- 4 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G";
            string item4buy = "- 4 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  구매완료";
            string item5notbuy = "- 5 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G";
            string item5buy = "- 5 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  구매완료";
            string item6notbuy = "- 6 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  3000 G";
            string item6buy = "- 6 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료";

            int gold = 1500;
            bool metalArmorIsE = false;
            bool spearIsE = false;
            bool oldswordIsE = false;
            bool item1IsE = false;
            bool item2IsE = false;
            bool item3IsE = false;
            bool item4IsE = false;
            bool item5IsE = false;
            bool item6IsE = false;


            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요.");
            string name = Console.ReadLine();
            Console.WriteLine("");

            Intro();


            //처음 나올 페이지
            void Intro()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("어서오세요, {0} 님.", name);
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
                    string defscore;

                    if (metalArmorIsE == false)
                    {
                        defscore = "방어력 : 5";
                    }
                    else
                    {
                        defscore = "방어력 : 10 (+5)";
                    }

                    string attackscore;

                    if (spearIsE == true && oldswordIsE == false)
                    {
                        attackscore = "공격력 : 17 (+7)";
                    }
                    else if (oldswordIsE == true && spearIsE == false)
                    {
                        attackscore = "공격력 : 12 (+2)";
                    }
                    else if (spearIsE == true && oldswordIsE == true)
                    {
                        attackscore = "공격력 : 19 (+9)";
                    }
                    else
                    {
                        attackscore = "공격력 : 10";
                    }

                    Console.WriteLine("");
                    Console.WriteLine("상태 보기");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                    Console.WriteLine("");
                    Console.WriteLine(name);
                    Console.WriteLine("Lv. 01");
                    Console.WriteLine("Chad ( 전사 )");
                    Console.WriteLine(attackscore);
                    Console.WriteLine(defscore);
                    Console.WriteLine("체 력 : 100");
                    Console.WriteLine("{0} G", gold);
                    Console.WriteLine("");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine("");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    int repeatNum = int.Parse(Console.ReadLine());
                    Menu(repeatNum);


                }

                else if (num == 2) // 2. 인벤토리
                {
                    inventory();

                }

                else if (num == 3) // 3. 상점 가기
                {
                    store();
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
                Console.Clear();
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
                Console.Clear();
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("");

                string inventory1;
                string inventory2;
                string inventory3;

                if (metalArmorIsE == false)
                {
                    inventory1 = metalArmor;
                }
                else
                {
                    inventory1 = metalArmorEquip;
                }

                if (spearIsE == false)
                {
                    inventory2 = spear;
                }
                else
                {
                    inventory2 = spearEquip;
                }

                if (oldswordIsE == false)
                {
                    inventory3 = oldsword;
                }
                else
                {
                    inventory3 = oldswordEquip;
                }


                Console.WriteLine(inventory1);
                Console.WriteLine(inventory2);
                Console.WriteLine(inventory3);
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
                    metalArmorIsE = !metalArmorIsE;
                    Manage();

                }

                else if (manageNum == 2)
                {
                    spearIsE = !spearIsE;
                    Manage();
                }

                else if (manageNum == 3)
                {
                    oldswordIsE = !oldswordIsE;
                    Manage();
                }

                else
                {
                    reEnter3();
                }


            }

            void reEnter3()
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("");
                int repetNum3 = int.Parse(Console.ReadLine());
                Manage2(repetNum3);
            }

            
            void store()
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("{0} G", gold);
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷 | 방어력 + 5 | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
                Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  2000 G");
                Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
                Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
                Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
                Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  3000 G");
                Console.WriteLine("");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                int storeNum = int.Parse(Console.ReadLine());
                storepage(storeNum);


            }

            void storepage(int storeNum)
            {
                if (storeNum == 0)
                {
                    Intro();
                }

                else if (storeNum == 1)
                {
                    storebuy();
                }

                else
                {
                    reEnter4();
                }

            }

            void reEnter4()
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("");
                int repetNum4 = int.Parse(Console.ReadLine());
                storepage(repetNum4);
            }

            void storebuy()
            {
                string item1var, item2var, item3var, item4var, item5var, item6var;

                if (item1IsE == false)
                {
                    item1var = item1notbuy;
                }
                else
                {
                    item1var = item1buy;
                }

                if (item2IsE == false)
                {
                    item2var = item2notbuy;
                }
                else
                {
                    item2var = item2buy;
                }

                if (item3IsE == false)
                {
                    item3var = item3notbuy;
                }
                else
                {
                    item3var = item3buy;
                }

                if (item4IsE == false)
                {
                    item4var = item4notbuy;
                }
                else
                {
                    item4var = item4buy;
                }

                if (item5IsE == false)
                {
                    item5var = item5notbuy;
                }
                else
                {
                    item5var = item5buy;
                }

                if (item6IsE == false)
                {
                    item6var = item6notbuy;
                }
                else
                {
                    item6var = item6buy;
                }

                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("{0} G", gold);
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine(item1var);
                Console.WriteLine(item2var);
                Console.WriteLine(item3var);
                Console.WriteLine(item4var);
                Console.WriteLine(item5var);
                Console.WriteLine(item6var);
                Console.WriteLine("");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                int storebuyNum = int.Parse(Console.ReadLine());
                storebuypage(storebuyNum);
            }

            void storebuypage(int storebuyNum)
            {
                if (storebuyNum == 0)
                {
                    store();
                }

                else if (storebuyNum == 1)
                {
                    if (gold >= 1000)
                    {
                        if (item1IsE == false)
                        {
                            item1IsE = true;
                            gold = gold - 1000;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item1IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }
                    }
                    else
                        {
                            Console.WriteLine("Gold가 부족합니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                    }
                    
                }

                else if (storebuyNum == 2)
                {
                    if (gold >= 2000)
                    {
                        if (item2IsE == false)
                        {
                            item2IsE = true;
                            gold = gold - 2000;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item2IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다");
                        int storepageNum = int.Parse(Console.ReadLine());
                        storebuypage(storepageNum);
                    }
                }

                else if (storebuyNum == 3)
                {
                    if (gold >= 3500)
                    {
                        if (item3IsE == false)
                        {
                            item3IsE = true;
                            gold = gold - 3500;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item3IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다");
                        int storepageNum = int.Parse(Console.ReadLine());
                        storebuypage(storepageNum);
                    }
                }

                else if (storebuyNum == 4)
                {
                    if (gold >= 600)
                    {
                        if (item4IsE == false)
                        {
                            item4IsE = true;
                            gold = gold - 600;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item4IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다");
                        int storepageNum = int.Parse(Console.ReadLine());
                        storebuypage(storepageNum);
                    }

                }

                else if (storebuyNum == 5)
                {
                    if (gold >= 1500)
                    {
                        if (item5IsE == false)
                        {
                            item5IsE = true;
                            gold = gold - 1500;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item5IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다");
                        int storepageNum = int.Parse(Console.ReadLine());
                        storebuypage(storepageNum);
                    }

                }

                else if (storebuyNum == 6)
                {
                    if (gold >= 3000)
                    {
                        if (item6IsE == false)
                        {
                            item6IsE = true;
                            gold = gold - 3000;
                            Console.WriteLine("구매를 완료했습니다.");
                            storebuy();
                        }
                        else if (item6IsE == true)
                        {
                            Console.WriteLine("이미 구매한 아이템입니다");
                            int storepageNum = int.Parse(Console.ReadLine());
                            storebuypage(storepageNum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다");
                        int storepageNum = int.Parse(Console.ReadLine());
                        storebuypage(storepageNum);
                    }

                }

                else
                {
                    reEnter5();
                }

                void reEnter5()
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("");
                    int repetNum5 = int.Parse(Console.ReadLine());
                    storebuypage(repetNum5);
                }

            }


        }


    }
}

