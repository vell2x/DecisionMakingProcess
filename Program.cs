using System;

namespace DecisionMakingProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "";
            do
            {
                Console.WriteLine("Enter a number between 1 and 100: ");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if(userNum % 2 == 0 && 0 < userNum && userNum < 25)
                {
                    Console.WriteLine(userNum + ", Even and less than 25.");
                }
                else if (userNum % 2 == 0 && 25 < userNum && userNum < 60)
                {
                    Console.WriteLine(userNum + ", Even and less than 60.");
                }
                else if (userNum % 2 == 0 && 60 < userNum && userNum <= 100)
                {
                    Console.WriteLine(userNum + ", Even.");
                }
                else if (userNum % 2 == 1 && userNum < 60)
                {
                    Console.WriteLine(userNum + ", Odd.");
                }
                else if (userNum % 2 == 1 && 60 < userNum && userNum <= 100)
                {
                    Console.WriteLine(userNum + ", Odd and over 60.");
                }
                else
                {
                    Console.WriteLine("Please enter valid number.");
                    continue;
                }
                Console.WriteLine("Do you want to continue?y/n: ");
                cont = Console.ReadLine();
            }
            while (!cont.Equals("N") && !cont.Equals("n"));
            Console.WriteLine("Goodbye!");
        }
    }
}
