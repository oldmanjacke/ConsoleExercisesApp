using System;

namespace ConsoleExercisesApp
{
    class Program
    {
        private static int yyyy;

        public static int MM { get; private set; }

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selectionNumber)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;

                        // Add new cases as you progress with your exercises

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid assigment number!");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            Console.WriteLine("Hello <firstname> <lastname>! I´am glad to inform you that you are the test subject of my very first assignment!");
        }

        private static void RunExerciseTwo()
        {
            var DataTime = new DateTime(2019, 10, 22);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour:" + now.Hour);
            //Console.WriteLine("Minute:" + now.Minute);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());

        }
        private static void RunExerciseThree()
  
        {
         
            
            {
                Console.WriteLine("What is your first name:");
                string name = Console.ReadLine();

                Console.WriteLine("What is your last name:");
                string lastName = Console.ReadLine();
               
                string fullName = name + " " + lastName;
                Console.WriteLine($"Your full name is: {fullName}");

                Console.ReadKey();
            }
            
      
        }

        // Cerate your exercise methods here
    }
}
