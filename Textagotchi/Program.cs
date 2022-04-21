using System.Collections.Generic;

namespace Textagotchi
{
    public static class Program
    {
        static List<string> Inventory = new List<string>();

        static void TestEvent1()
        {
            Console.Beep();
            Console.WriteLine("Beeped");
        }

        static void TestEvent2()
        {
            Console.WriteLine("Test1");
        }

        static void TestEvent3()
        {
            Console.WriteLine("Test2");
        }

        // Create the function delegate:
        private delegate void RandomFunction();

        public static void Main(string[] args)
            
        {
            string? tama;
            string? location;
            int money = 0;
            int milliseconds = 5000;
            bool entry = false;
            string[] help = {"help", "info", "coingame", "edit", "inventory", "shop"};
            bool helpentry = false;


            Console.WriteLine("Enter your Pet's Name.");
            tama = Console.ReadLine();
            if (tama == "")
            {
                tama = "Tamagotchi";
            }
            Console.WriteLine("What an interesting and special name that is totally unique. \n");
            Console.WriteLine("Anyways, where does your " + tama + " live?");
            location = Console.ReadLine();
            if (location == "")
            {
                location = "Your Pocket";
            }
            Console.WriteLine("\nWell, who would have guessed. Anyways, Welcome and good luck taking care of your " + tama);
            
            Console.WriteLine("\nProceeding in 5 Seconds");
            Thread.Sleep(milliseconds);
            Console.Clear();
            entry = true;


            while (entry == true)
            {

                if (helpentry == false)
                {
                    helpentry = true;
                    Console.WriteLine("\nEnter 'help' to find commands.");
                    Console.WriteLine("Enter a Prompt");
                }

                else
                {
                    Console.WriteLine("\nEnter a Prompt");
                }
                
                string? input = Console.ReadLine();

                if ((input == "help") || (input == "commands"))
                {
                    Console.WriteLine("");
                    Array.ForEach(help, Console.WriteLine);

                }
                if (input == "info")
                {
                    Console.WriteLine("Pet Name: " + tama);
                    Console.WriteLine("Location: " + location);
                    Console.WriteLine("Money Held: $" + money);
                    Console.WriteLine("Current Time: " + DateTime.Now.ToString());
                }

                if (input == "inventory")
                {
                    Console.WriteLine("You currently have the following items:\n");

                    foreach (string item in Inventory)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (input == "edit")
                {
                    Console.WriteLine("Please enter a new name for your Tamagotchi");
                    tama = Console.ReadLine();
                    Console.WriteLine("Please enter a new location for your Tamagotchi");
                    location = Console.ReadLine();
                }

                if (input == "shop")
                {
                    while (true)
                    {
                        Console.WriteLine("We have the following items.\n");
                        Console.WriteLine("[1] Canned Food - $30");

                        Console.WriteLine("\nLeave blank to exit.");

                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            if (money >= 30)
                            {
                                Console.WriteLine("Added Canned Food");
                                Inventory.Add("Canned Food");
                                money-= 30;
                            }

                            if (money <= 30)
                            {
                                Console.WriteLine("Not Enough Money.");

                            }

                        }


                        if (input == "")
                        {
                            break;
                        }
                    }
                }

                if ((input == "among us") || (input == "amongus") || (input == "sus") || (input == "amogus") || (input == "imposter") || (input == "sussy"))
                {
                    Console.WriteLine("You're Not Funny.");
                }

                if (input == "coingame")

                {
                    Console.Clear();
                    int numPlays = 0, numWins = 0;
                    int compChoice = 0;
                    char userChoice;
                    double percentWin;
                    int gambletimer = 2000;
                    int endgambletimer = 5000;
                    Random rnd = new();
                    while (true)
                    {
                        Console.Write("\nWrite H/h to guess Heads, T/t to guess Tails, or Q/q to quit =>  ");
                        userChoice = Console.ReadKey().KeyChar;
                        compChoice = rnd.Next(0, 2);
                        if (char.ToLowerInvariant(userChoice) != 'q')
                        {
                            if (char.ToLowerInvariant(userChoice) == 'h' && compChoice == 0)
                            {
                                Console.WriteLine("\n...");
                                Thread.Sleep(gambletimer);
                                Console.WriteLine("\nYOU WON");
                                Console.WriteLine("\nYOU EARNED $2");
                                money = money + 2;
                                numWins++;
                            }
                            else if (char.ToLowerInvariant(userChoice) == 't' && compChoice == 1)
                            {
                                Console.WriteLine("\n...");
                                Thread.Sleep(gambletimer);
                                Console.WriteLine("\nYOU WON");
                                Console.WriteLine("\nYOU EARNED $2");
                                money = money + 2;
                                numWins++;
                            }
                            else
                            {
                                Console.WriteLine("\n...");
                                Thread.Sleep(gambletimer);
                                Console.WriteLine("\nYOU LOSE");
                            }
                            numPlays++;
                        }
                        else
                        {
                            percentWin = (double)numWins / numPlays;
                            Console.WriteLine("\nYou won {0} out of {1} game(s) or {2:P} of the games played.", numWins, numPlays, percentWin);
                            Console.WriteLine("Won a Total of $" + money);
                            Thread.Sleep(endgambletimer);
                            Console.Clear();
                            break;
                        }

                    }


                }

                // Debug Commands
                if (input == "randomtest")
                {
                    // Create a list of these delegates:
                    List<RandomFunction> functions = new List<RandomFunction>();

                    // Add the functions to the list:
                    functions.Add(TestEvent1);
                    functions.Add(TestEvent2);
                    functions.Add(TestEvent3);

                    // Make our randomizer:
                    Random rand = new Random();

                    // Call one:
                    functions[rand.Next(0, 3)](); // Random number (min, max)
                }

                if (input == "add dummy")
                {
                    Console.WriteLine("Added Dummy Item to Inventory.");
                    Inventory.Add("dummyDEBUG");
                }

                if (input == "MONEYCHEATER")
                {
                    money = 9999999;
                }
            }

        }
    }
}