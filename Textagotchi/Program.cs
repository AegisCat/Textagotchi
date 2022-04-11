

namespace Textagotchi
{
    class Program
    {

        public static void Main(string[] args)

        {
            string textagotchi;
            string location;
            int milliseconds = 5000;
            Console.WriteLine("Enter your Pet's Name.");
            textagotchi = Console.ReadLine();
            Console.WriteLine("What an interesting and special name that is totally unique. \n");
            Console.WriteLine("Anyways, where does your " + textagotchi + " live?");
            location = Console.ReadLine();
            Console.WriteLine("\nWell, who would have guessed. Anyways, Welcome and good luck taking care of your " + textagotchi);
            Console.WriteLine("\nProceeding in 5 Seconds");
            Thread.Sleep(milliseconds);
            Console.Clear();

        }
    }
}