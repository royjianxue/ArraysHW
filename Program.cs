using System;

namespace ArraysHW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            int pick;
            string exitProgram;
            string [] names = new string[] {"Roy", "Raven", "Raya", "Roxy"};
            do
            {
                System.Console.Write("Please select a number(0 - 3) to print a name: ");
                string selection = Console.ReadLine();
                if(int.TryParse(selection, out pick))
                {
                    if(pick < names.Length)
                    {
                        Console.WriteLine($"Picked name is {names[pick]}.");
                    }
                    else
                    {
                        Console.WriteLine("You have exceeded the length of the array.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
                Console.Write("Do you wish to exit the program? yes --> exit.. Any --> continue.. ");
                exitProgram = System.Console.ReadLine();
                if (exitProgram.ToUpper() == "YES")
                {
                    Console.WriteLine("You are exiting the program....");
                    Console.ReadKey();
                    keepGoing = false;
                }

            } while (keepGoing);
        }
    }
}
