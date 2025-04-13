using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            BlackJackHand player = new BlackJackHand();
            BlackJackHand dealer = new BlackJackHand();

            // Initial cards
            player.AddCard(deck.DealCard());
            player.AddCard(deck.DealCard());

            dealer.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());

            player.Display("Player");
            Console.WriteLine("Player Total: " + player.GetHandValue());

            Console.WriteLine($"\nDealer shows: {dealer.GetCards()[0]}");

            // Player turn
            while (!player.IsBusted())
            {
                Console.Write("\nHit or Stand? (h/s): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "h")
                {
                    player.AddCard(deck.DealCard());
                    player.Display("Player");
                    Console.WriteLine("Player Total: " + player.GetHandValue());
                }
                else if (choice == "s") break;
            }

            if (player.IsBusted())
            {
                Console.WriteLine("\nBusted! Dealer wins.");
            }
            else
            {
                dealer.AutoPlayDealer(deck);
                dealer.Display("Dealer");
                Console.WriteLine("Dealer Total: " + dealer.GetHandValue());

                int playerVal = player.GetHandValue();
                int dealerVal = dealer.GetHandValue();

                if (dealer.IsBusted() || playerVal > dealerVal)
                    Console.WriteLine("\nYou win!");
                else if (playerVal < dealerVal)
                    Console.WriteLine("\nDealer wins!");
                else
                    Console.WriteLine("\nIt's a tie!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
