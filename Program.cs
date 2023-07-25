

using System;

namespace dicegame
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            int[] moneyWin = new int[3];
            while (1 == 1) 
            {
            Random rnd = new Random();
            int[] output = new int[3];
            int i = new int();
            double money = 10;
            bool debug = false;
            
            for (i = 1; i <= 5; i++)
            {
                int j = rnd.Next(1, 21);
                int k = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
                int l = rnd.Next(1, 21);
                if (j < k && k < l)
                {
                    output[0]++;
                    money = money / 2;
                    if (debug)
                    {
                        Console.WriteLine("Between");
                    };

                }
                else if (k < j || k > l)
                {
                    output[1]++;
                    money = 1.5 * money;
                    if (debug)
                    {
                        Console.WriteLine("Outside");
                    };
                }
                else if (k == j || k == l)
                {
                    output[2]++;
                    if (debug)
                    {
                        Console.WriteLine("Wash");
                    };
                }
                if (debug)
                {
                    Console.WriteLine(j + " " + k + " " + l);
                    Console.WriteLine(money);
                }
            }
            Console.WriteLine("Between: " + output[0]);
            Console.WriteLine("Outside: " + output[1]);
            Console.WriteLine("Wash: " + output[2]);
            Console.WriteLine("Money: " + money);
            if (money > 10)
            {
                moneyWin[0]++;
            }
            else if (money < 10) 
            {
                moneyWin[1]++;
            }
            else if (money == 10)
            {
                moneyWin[2]++;
            }
            Console.WriteLine("Win: " + moneyWin[0] + ", Lose: " + moneyWin[1] + ", Even: " + moneyWin[2]);
            Console.ReadKey();
        }
    }
    }
}