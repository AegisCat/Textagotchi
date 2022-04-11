

namespace Textagotchi
{
    class Program
    {

        public static void Main(string[] args)

        {
            string tama;
            string location;
            int level = 1;
            int milliseconds = 5000;
            bool entry = false;
            string[] help = {"help", "info"};
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
                }

                if (input == "among us")
                {
                    Console.WriteLine("You're Not Funny.");
                }
            }

        }
    }
}