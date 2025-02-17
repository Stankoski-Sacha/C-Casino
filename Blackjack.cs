using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C__Casino
{
    class Blackjack
    {
        public void main()
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                Console.WriteLine("Would you like to play? (Yes/No)");
                String action = Console.ReadLine().ToLower().Trim();
                switch (action)
                {
                    case "yes":
                        play();
                        break;
                    case "no":
                        Menu menu = new Menu();
                        Menu.menu();
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }
        }

        static void play()
        {
            Random ran = new Random();

            int total = 0;

            int card = ran.Next(1, 11);
            int dealer = ran.Next(19, 22);
            Console.WriteLine("Drawing Cards...");
            Thread.Sleep(2000);
            total = card + card;

            Console.WriteLine("Your total is: " + total);

            if (total == 21)
            {
                Console.WriteLine("You won"); 
            }

            Console.WriteLine("Hit or Stand?");
            String action = Console.ReadLine();

            
            while (total < 22)
            {
                switch (action)
                {
                    case "Hit":
                        card = ran.Next(1, 11);
                        total += card;
                        Console.WriteLine("Your total is: " + total);
                        if (total > 21)
                        {
                            Console.WriteLine("You busted!");
                            break;
                        }
                        Console.WriteLine("Hit or Stand?");
                        action = Console.ReadLine();
                        break;
                    case "Stand":
                        Console.WriteLine("Dealer total is: " + dealer);
                        if (total > dealer)
                        {
                            Console.WriteLine("You won!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                            total += 100;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }
        }
    }
}