using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {

        public static int GetInput()
        {
            string input_str = Console.ReadLine();  
            return int.Parse(input_str);
        }

        static void Main(string[] args)
        {
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
                input = GetInput();

                //離開條件 
                if (input == guess)
                {
                    Console.WriteLine("恭喜你答對了!");
                    break;
                }

                //提示
                Console.WriteLine("猜錯了，再來一次！");
            }

            //離開遊戲
            Console.ReadKey();
        }
    }
}
