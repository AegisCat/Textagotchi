namespace Textagotchi
{
    class Program
    {

        public static void Main(string[] args)
            
        {
            string? tama;
            string? location;
            int money = 0;
            int milliseconds = 5000;
            bool entry = false;
            string[] help = {"help", "info", "coingame", "edit"};
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

                if (input == "edit")
                {
                    Console.WriteLine("Please enter a new name for your Tamagotchi");
                    tama = Console.ReadLine();
                    Console.WriteLine("Please enter a new location for your Tamagotchi");
                    location = Console.ReadLine();
                }

                if ((input == "among us") || (input == "amongus") || (input == "sus"))
                {
                    Console.WriteLine("You're Not Funny.");
                }

                if (input == "coingame")

                {
                    int numPlays = 0, numWins = 0;
                    int compChoice = 0;
                    char userChoice;
                    double percentWin;
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
                                Console.WriteLine("\nYOU WON");
                                Console.WriteLine("\nYOU EARNED $2");
                                money = money + 2;
                                numWins++;
                            }
                            else if (char.ToLowerInvariant(userChoice) == 't' && compChoice == 1)
                            {
                                Console.WriteLine("\nYOU WON");
                                Console.WriteLine("\nYOU EARNED $2");
                                money = money + 2;
                                numWins++;
                            }
                            else
                            {
                                Console.WriteLine("\nYOU LOSE");
                            }
                            numPlays++;
                        }
                        else
                        {
                            percentWin = (double)numWins / numPlays;
                            Console.WriteLine("\nYou won {0} out of {1} game(s) or {2:P} of the games played.", numWins, numPlays, percentWin);
                            Console.WriteLine("Won a Total of $" + money);
                            break;
                        }

                    }


                }
            }

        }
    }
}