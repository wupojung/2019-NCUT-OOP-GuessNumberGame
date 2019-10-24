using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Game
    {
        public Game()
        {
            Console.WriteLine("發生建構!!!");
        }

        public void Play()
        {
            Console.WriteLine("開始遊戲吧!!!");

            int input = -1;
            int guess = 55;

            //產生亂數
            guess = new Random().Next(100);

            //UI 提醒
            Console.WriteLine("請輸入一個數字(0-100):");

            //遊戲主迴圈
            while (true)  //game loop 
            {
                //決定輸入內容                
                input = GetInput(0, 100);

                //離開條件 
                if (input == guess)
                {
                    Console.WriteLine("恭喜你答對了!");
                    break;
                }

                //提示
                Console.WriteLine("猜錯了，再來一次！");
            }

        }

        public static int GetInput(int min, int max)
        {
            int result = -1;
            try
            {
                while (true)
                {
                    string input_str = Console.ReadLine();

                    if (int.TryParse(input_str, out result))
                    {
                        result = int.Parse(input_str);

                        //離開的條件
                        if (result >= min && result <= max)
                        {
                            break;
                        }
                        Console.WriteLine("您輸入的數字不在範圍內，請重新輸入一個數字(0-100):");
                    }
                    else
                    {
                        //輸入的不是數字
                        Console.WriteLine("您輸入的不是數字，請重新輸入一個數字(0-100):");
                    }
                }
            }
            catch (Exception exp)
            {
                //爆炸了....
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }

    }
}
