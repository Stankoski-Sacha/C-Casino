using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C__Casino.code
{
    class Blackjack
    {
        public void main()
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                Console.WriteLine("Would you like to play? (Yes/No)");
                string action = Console.ReadLine().ToLower().Trim();
                switch (action)
                {
                    case "yes":
                        Console.WriteLine("How much tokens would you like to bet?");
                        int bet = int.Parse(Console.ReadLine());
                        if (bet > data.Tokens)
                        {
                            Console.WriteLine("You do not have enough tokens.");
                            break;
                        }
                        play(bet);
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

        static void play(int bet)
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
                total+= 100;
                data.Tokens += (bet * 3);
            }

            Console.WriteLine("Hit or Stand?");
            string action = Console.ReadLine().Trim().ToLower();


            while (total < 22)
            {
                switch (action)
                {
                    case "hit":
                        card = ran.Next(1, 11);
                        total += card;
                        Console.WriteLine("Your total is: " + total);
                        if (total > 21)
                        {
                            Console.WriteLine("You busted!");
                            break;
                        }
                        else if (total == 21)
                        {
                            Console.WriteLine("You won!");
                            total += 100;
                            data.Tokens += (bet * 2);
                            break;
                        }
                        Console.WriteLine("Hit or Stand?");
                        action = Console.ReadLine();
                        break;
                    case "stand":
                        Console.WriteLine("Dealer total is: " + dealer);
                        if (total > dealer)
                        {
                            Console.WriteLine("You won!");
                            total += 100;
                            break;
                        }
                        else if (total == dealer)
                        {
                            Console.WriteLine("It's a tie! You get back your tokens");
                            total += 100;
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
                        Console.WriteLine("Hit or Stand?");
                        action = Console.ReadLine();
                        break;
                }
            }
        }
    }
}