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
            string[] help = { "help", "info", "coingame", "wordle", "edit", "inventory", "shop" };
            bool helpentry = false;
            List<string> Words = new List<string>();

            //Word List  
            Words.Add("adult");
            Words.Add("agent");
            Words.Add("anger");
            Words.Add("apple");
            Words.Add("award");
            Words.Add("beach");
            Words.Add("birth");
            Words.Add("block");
            Words.Add("board");
            Words.Add("brain");
            Words.Add("bread");
            Words.Add("break");
            Words.Add("brown");
            Words.Add("brand");
            Words.Add("beast");
            Words.Add("bench");
            Words.Add("cello");
            Words.Add("beans");
            Words.Add("brave");
            Words.Add("brass");
            Words.Add("grass");
            Words.Add("green");
            Words.Add("mouse");
            Words.Add("bored");
            Words.Add("board");
            Words.Add("beard");
            Words.Add("phone");
            Words.Add("brick");
            Words.Add("breed");
            Words.Add("plane");
            Words.Add("plank");
            Words.Add("squat");
            Words.Add("camel");
            Words.Add("crown");
            Words.Add("crate");
            Words.Add("creed");
            Words.Add("greed");
            Words.Add("plead");
            Words.Add("speed");
            Words.Add("steed");
            Words.Add("carry");
            Words.Add("curry");
            Words.Add("hurry");
            Words.Add("cause");
            Words.Add("chain");
            Words.Add("motto");
            Words.Add("count");
            Words.Add("glass");
            Words.Add("candy");
            Words.Add("laugh");
            Words.Add("anime");
            Words.Add("manga");
            Words.Add("demon");
            Words.Add("scare");
            Words.Add("stole");
            Words.Add("stand");
            Words.Add("sheet");
            Words.Add("music");
            Words.Add("staff");
            Words.Add("steal");
            Words.Add("panda");
            Words.Add("print");
            Words.Add("perch");
            Words.Add("parch");
            Words.Add("purse");
            Words.Add("craft");
            Words.Add("close");
            Words.Add("clash");
            Words.Add("clock");
            Words.Add("cream");
            Words.Add("climb");
            Words.Add("gongs");
            Words.Add("power");
            Words.Add("snake");
            Words.Add("badge");
            Words.Add("paper");
            Words.Add("chair");
            Words.Add("table");
            Words.Add("spoon");
            Words.Add("knife");
            Words.Add("plate");
            Words.Add("pasta");
            Words.Add("spill");
            Words.Add("spork");
            Words.Add("sport");
            Words.Add("trash");
            Words.Add("model");
            Words.Add("chest");
            Words.Add("limit");
            Words.Add("cloud");
            Words.Add("chief");
            Words.Add("spine");
            Words.Add("boing");
            Words.Add("chore");
            Words.Add("paint");
            Words.Add("white");
            Words.Add("black");
            Words.Add("child");
            Words.Add("coast");
            Words.Add("night");
            Words.Add("human");
            Words.Add("puppy");
            Words.Add("zebra");
            Words.Add("sound");
            Words.Add("chime");
            Words.Add("river");
            Words.Add("piano");
            Words.Add("shirt");
            Words.Add("under");
            Words.Add("haven");
            Words.Add("ghost");
            Words.Add("scarf");
            Words.Add("grill");
            Words.Add("chill");
            Words.Add("crack");
            Words.Add("sugar");
            Words.Add("flour");
            Words.Add("melon");
            Words.Add("money");
            Words.Add("mango");
            Words.Add("bring");
            Words.Add("broom");
            Words.Add("sting");
            Words.Add("steam");
            Words.Add("smell");
            Words.Add("taste");
            Words.Add("sight");
            Words.Add("touch");
            Words.Add("voice");
            Words.Add("speak");
            Words.Add("after");
            Words.Add("while");
            Words.Add("stick");
            Words.Add("stern");
            Words.Add("spank");
            Words.Add("spank");
            Words.Add("bling");
            Words.Add("broke");
            Words.Add("brain");
            Words.Add("brawl");
            Words.Add("misty");
            Words.Add("blink");
            Words.Add("flame");
            Words.Add("ditto");
            Words.Add("drink");
            Words.Add("koala");
            Words.Add("clown");
            Words.Add("hover");
            Words.Add("cower");
            Words.Add("cover");
            Words.Add("tower");
            Words.Add("glock");
            Words.Add("roach");
            Words.Add("harsh");
            Words.Add("cross");
            Words.Add("disco");
            Words.Add("cocoa");
            Words.Add("slide");
            Words.Add("aback");
            Words.Add("acorn");
            Words.Add("admin");
            Words.Add("essay");
            Words.Add("fruit");
            Words.Add("humor");
            Words.Add("chant");
            Words.Add("banjo");
            Words.Add("cough");


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
                                money -= 30;
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


                if (input == "wordle")
                {
                    Console.Clear();
                    int wordletimer = 5000;
                    string? answer = "no";

                    //Random Word Picker
                    Random numberGen = new Random();

                    int random = 0;

                    while (true)   //Choices
                    {

                        Console.WriteLine("Start the game");
                        Console.WriteLine("Do You Want Hard Mode?");
                        answer = Console.ReadLine();


                        //Yes
                        if (answer == "yes")
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                random = numberGen.Next(0, 163);
                            }
                            string theWord = (Words[random]);
                            Console.WriteLine("Type your first guess (lowercase only)");

                            //Guessing

                            for (int i = 0; i < 7; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;

                                string? guess = Convert.ToString(Console.ReadLine());

                                char a = theWord[0];
                                char b = theWord[1];
                                char c = theWord[2];
                                char d = theWord[3];
                                char e = theWord[4];

                                char aa = guess[0];
                                char bb = guess[1];
                                char cc = guess[2];
                                char dd = guess[3];
                                char ee = guess[4];

                                //First Letter Guess
                                if (a == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(aa);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(aa);
                                }

                                //Second Letter
                                if (b == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(bb);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(bb);
                                }

                                //Third Letter
                                if (c == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(cc);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(cc);
                                }

                                //Fourth Letter
                                if (d == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(dd);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(dd);
                                }

                                //Fifth Letter
                                if (e == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }


                                //Win
                                if (guess == theWord)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("You did it!");
                                    i = 999;
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("The Word Was: " + theWord);
                            Console.WriteLine("You Won $100");
                            money = money + 100;
                        }

                        //No
                        else if (answer == "no")
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                random = numberGen.Next(0, 163);
                            }
                            string theWord = (Words[random]);
                            Console.WriteLine("Type your first guess (lowercase only)");

                            //Guessing

                            for (int i = 0; i < 60; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;

                                string? guess = Convert.ToString(Console.ReadLine());

                                char a = theWord[0];
                                char b = theWord[1];
                                char c = theWord[2];
                                char d = theWord[3];
                                char e = theWord[4];
  
                                char aa = guess[0];
                                char bb = guess[1];
                                char cc = guess[2];
                                char dd = guess[3];
                                char ee = guess[4];

                                //First Letter
                                if (a == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(aa);
                                }
                                else if (b == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(aa);
                                }
                                else if (c == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(aa);
                                }
                                else if (d == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(aa);
                                }
                                else if (e == aa)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(aa);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(aa);
                                }

                                //Second Letter
                                if (b == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(bb);
                                }
                                else if (a == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(bb);
                                }
                                else if (c == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(bb);
                                }
                                else if (d == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(bb);
                                }
                                else if (e == bb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(bb);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(bb);
                                }

                                //Third Letter
                                if (c == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(cc);
                                }
                                else if (a == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(cc);
                                }
                                else if (b == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(cc);
                                }
                                else if (d == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(cc);
                                }
                                else if (e == cc)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(cc);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(cc);
                                }

                                //Fourth Letter
                                if (d == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(dd);
                                }
                                else if (a == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(dd);
                                }
                                else if (b == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(dd);
                                }
                                else if (c == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(dd);
                                }
                                else if (e == dd)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(dd);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(dd);
                                }

                                //Fifth Letter
                                if (e == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else if (a == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else if (b == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else if (c == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else if (d == ee)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ee);
                                    Console.WriteLine("");
                                }

                                //Win
                                if (guess == theWord)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("You did it!");
                                    Console.WriteLine("You Won $100");
                                    money = money + 100;

                                    i = 999;
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("The Word Was: " + theWord);
                        }

                        //Wait Before Closing
                        Console.WriteLine("Press Any Key to Continue:");
                        Console.ReadKey();
                        Console.Clear();
                        break;
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