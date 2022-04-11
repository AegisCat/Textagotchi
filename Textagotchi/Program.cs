

namespace Textagotchi
{
    class Program
    {

        public static void Main(string[] args)

        {
            string tama;
            string location;
            int level = 1;
            float experience = 0;
            int milliseconds = 5000;
            bool entry = false;
            string[] help = {"help", "info", "coingame"};
            bool helpentry = false;

            Console.WriteLine("Enter your Pet's Name.");
            tama = Console.ReadLine();
            Console.WriteLine("What an interesting and special name that is totally unique. \n");
            Console.WriteLine("Anyways, where does your " + tama + " live?");
            location = Console.ReadLine();
            Console.WriteLine("\nWell, who would have guessed. Anyways, Welcome and good luck taking care of your " + tama);
            
            Console.WriteLine("\nProceeding in 5 Seconds");
            Thread.Sleep(milliseconds);
            Console.Clear();
            entry = true;

            while (entry == true)
            {
                if (experience >= 10 && experience <= 29)
                {
                    level = 2;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 30 && experience <= 59)
                {
                    level = 3;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 60 && experience <= 99)
                {
                    level = 4;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 100 && experience <= 199)
                {
                    level = 5;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 200 && experience <= 499)
                {
                    level = 6;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 500 && experience <= 999)
                {
                    level = 7;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 1000 && experience <= 1999)
                {
                    level = 8;
                    Console.WriteLine("\nLeveled Up!");

                }

                if (experience >= 2000)
                {
                    level = 9;
                    Console.WriteLine("\nLeveled Up!");

                }


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
                
                string input = Console.ReadLine();
                Console.WriteLine("");

                if (input == "help")
                {
                    Array.ForEach(help, Console.WriteLine);

                }
                if (input == "info")
                {
                    Console.WriteLine("Pet Name: " + tama);
                    Console.WriteLine("Location: " + location);
                    Console.WriteLine("Level: " + level);
                    Console.WriteLine("Experience: " + experience);
                }

                if (input == "among us")
                {
                    Console.WriteLine("You're Not Funny.");
                }

                if (input == "coingame")

                {
                    int numPlays = 0, numWins = 0;
                    int compChoice = 0;
                    char userChoice;
                    double percentWin;
                    Random rnd = new Random();
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
                                Console.WriteLine("\nGained 2 EXP");
                                experience = experience + 2;
                                numWins++;
                            }
                            else if (char.ToLowerInvariant(userChoice) == 't' && compChoice == 1)
                            {
                                Console.WriteLine("\nYOU WON");
                                Console.WriteLine("\nGained 2 EXP");
                                experience = experience + 2;
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
                            break;
                        }

                    }


                }
            }

        }
    }
}