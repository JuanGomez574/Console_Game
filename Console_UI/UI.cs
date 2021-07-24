using System;
using ZenerCardGame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    class UI
    {
        public PlayerOne Player1 = new PlayerOne();
        public PlayerTwo Player2 = new PlayerTwo();



        //UI Run Method for the program UI.Run()
        public void Run()
        {
            RunGame();
        }

        //Menu Methods
        public void RunGame()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("Welcome. What would you like to do?\n" +
                    "1. Play a Zener Card Game.\n" +
                    "2. Exit.\n");

                string userInput = Console.ReadLine();

                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        Game();
                        break;
                    case "2":
                        Console.WriteLine("Press any key to exit ...");
                        Console.ReadKey();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option. Please select an option by using the number of the option.");
                        break;
                }
            }
        }

        public void Game()
        {
            bool playingGame = true;
            while (playingGame)
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the game \n" +
                        "Please enter name of Player One");

                string playerOneName = Console.ReadLine();

                Console.Clear();

                Player1.name = playerOneName;

                Console.WriteLine("Great! Now please enter name of Player Two.");
                string playerTwoName = Console.ReadLine();

                Player2.name = playerTwoName;

                
                DeckOfCards gameDeck = new DeckOfCards();


                Console.WriteLine("How many cards will we have in our deck today");

                int numberChoice = int.Parse(Console.ReadLine());
                //gameDeck.AmountOfCards = numberChoice;

                //int[] numberArray = new int[numberChoice];
                //gameDeck.Deck = numberArray;

                DeckOfCards newDeck = new DeckOfCards();

                newDeck.SetUpDeck(numberChoice);


                //Random rnd = new Random();
                //for (int i = 0; i < numberArray.Length; i++)
                //{
                //    gameDeck.AmountOfCards = rnd.Next(1, 4);
                //    //int[] numberArray = new int[gameDeck.AmountOfCards];
                //    gameDeck.Deck = numberArray;
                //    //return gameDeck.Deck;

                //}
                //gameDeck.Deck.










                // DeckObject gameDeck = new DeckObject(numberChoice, numberArray); //DeckObject.deck[]

                //gameDeck.Deck = numberArray;
                //gameDeck.AmountOfCards = 8:;

                //we fill the indexes in the deck with a random number from 1 to 4
                //for (int i = 0; i < gamedeck.AmountOfCards; ++i)
                //{ deck[i] = Random.Next(1, 4); }
                //return deck[];



            }
        }
    }
}

