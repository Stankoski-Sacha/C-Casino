using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Casino
{
    class Menu
    {
       public static void menu()
        {
            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("     Welcome to the C# Casino!   ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Blackjack");
                Console.WriteLine("5. Balance");
                Console.WriteLine("6. Exit"); 
                int action = int.Parse(Console.ReadLine());

                if (action == 6) break;

                switch (action)
                {
                    case 1:
                        Blackjack blackjack = new Blackjack();
                        blackjack.main();
                        break;
                    case 5:
                        Console.WriteLine("Your balance is: " + data.Balance);
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }
        }
    }
}
