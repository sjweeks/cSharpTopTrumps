using System;
using System.Collections.Generic;

namespace cSharpTopTrumps
{
    class Cards
    {
        public string Name;
        public double Health;
        public double Magic;
        public double Courage;

        public void DealDeck()
        {
            string userInput;

            List<Cards> deck1 = new List<Cards>();
            List<Cards> deck2 = new List<Cards>();
            List<Cards> holdDeck = new List<Cards>();
            deck1.Add(new Cards { Name = "Harry Potter", Health = 78, Magic = 95, Courage = 93 });
            deck1.Add(new Cards { Name = "Hermione Granger", Health = 90, Magic = 80, Courage = 88 });
            deck1.Add(new Cards { Name = "Ronald Weasley", Health = 80, Magic = 63, Courage = 82 });
            deck1.Add(new Cards { Name = "Voldemort", Health = 15, Magic = 94, Courage = 40 });
            deck1.Add(new Cards { Name = "Albus Dumbledore", Health = 72, Magic = 94, Courage = 92 });

            deck2.Add(new Cards { Name = "Draco Malfoy", Health = 63, Magic = 67, Courage = 62 });
            deck2.Add(new Cards { Name = "Sirius Black", Health = 75, Magic = 78, Courage = 89 });
            deck2.Add(new Cards { Name = "Professor McGonagell", Health = 74, Magic = 76, Courage = 86 });
            deck2.Add(new Cards { Name = "Severus Snape", Health = 81, Magic = 83, Courage = 91 });
            deck2.Add(new Cards { Name = "Bellatrix LeStrange", Health = 59, Magic = 71, Courage = 41 });

            Console.WriteLine("Deck 1 cards are:");
            for (int i = 0; i < deck1.Count; i++)
            {
                Console.WriteLine(deck1[i].Name);
            }
            Console.ReadKey();
            Console.WriteLine("Deck 2 cards are:");
            for (int i = 0; i < deck2.Count; i++)
            {
                Console.WriteLine(deck2[i].Name);
            }
            Console.ReadKey();

            Console.WriteLine("Choose value to compare: 1 - Health, 2 - Magic, 3 - Courage");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You have chosen to compare Health");
                Console.ReadKey();
                // HealthFunc();
                Console.WriteLine("Deck 1 your value is: {0}", deck1[0].Health);
                Console.WriteLine("Deck 2 your value is: {0}", deck2[0].Health);
                Console.ReadKey();
                if (deck1[0].Health > deck2[0].Health)
                {
                    Console.WriteLine("Deck 1 Won");
                    deck1.Add(deck2[0]);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0].Health < deck2[0].Health)
                {
                    Console.WriteLine("Deck 2 Won");
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                // Console.WriteLine("Deck 1 new cards are:");
                // for (int i = 0; i < deck1.Count; i++)
                // {
                //     Console.WriteLine(deck1[i].Name);
                // }
                // Console.ReadKey();
                // Console.WriteLine("Deck 2 new cards are:");
                // for (int i = 0; i < deck2.Count; i++)
                // {
                //     Console.WriteLine(deck2[i].Name);
                // }
                // Console.ReadKey();

            }
            else if (userInput == "2")
            {
                Console.WriteLine("You have chosen to compare Magic");
                Console.ReadKey();
                // MagicFunc();
                Console.WriteLine("Deck 1 your value is: {0}", deck1[0].Magic);
                Console.WriteLine("Deck 2 your value is: {0}", deck2[0].Magic);
                Console.ReadKey();
                if (deck1[0].Magic > deck2[0].Magic)
                {
                    Console.WriteLine("Deck 1 Won");
                    deck1.Add(deck2[0]);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0].Magic < deck2[0].Magic)
                {
                    Console.WriteLine("Deck 2 Won");
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("Draw");
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("You have chosen to compare Courage");
                Console.ReadKey();
                Console.WriteLine("Deck 1 your value is: {0}", deck1[0].Courage);
                Console.WriteLine("Deck 2 your value is: {0}", deck2[0].Courage);
                Console.ReadKey();
                // CourageFunc();
                if (deck1[0].Courage > deck2[0].Courage)
                {
                    Console.WriteLine("Deck 1 Won");
                    deck1.Add(deck2[0]);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0].Courage < deck2[0].Courage)
                {
                    Console.WriteLine("Deck 2 Won");
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("Draw");
                }
            }
        }
    }
}

// public void HealthFunc()
// {
    
//     if (deck1[0].Health > deck2[0].Health)
//     {

//     }
// }
// public void MagicFunc()
// {

// }
// public void CourageFunc()
// {

// }