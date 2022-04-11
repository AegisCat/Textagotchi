

namespace Textagotchi
{
    class Program
    {

        public static void Main(string[] args)

        {
            string tama;
            string location;
            int milliseconds = 5000;
            bool entry = false;

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
                Console.WriteLine("Enter a Prompt");
                
                string input = Console.ReadLine();

                if (input == "info")
                {
                    Console.WriteLine("\nPet Name: " + tama);
                    Console.WriteLine("\nLocation: " + location);

                
                }


                

            }

        }
    }
}