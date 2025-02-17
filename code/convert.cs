using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Casino.code
{
    class convert
    {
        public static void Convert()
        {
            int money = data.Balance;
            int tokens = data.Tokens;

            Console.WriteLine("Convert to 1) Tokens or 2) Money?");
            String action = Console.ReadLine().ToLower().Trim();

            switch (action)
            {
                case "1":
                    Console.WriteLine("How many ? 1 Token = 10 money");
                    int amount = int.Parse(Console.ReadLine());
                    if (money < amount)
                    {
                        Console.WriteLine("You do not have enough money.");
                    }
                    else
                    {
                        data.Balance -= amount;
                        data.Tokens += amount / 10;
                    }
                    break;

            }
        }
    }
}
