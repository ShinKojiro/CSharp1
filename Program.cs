using System;

namespace _1
{
    class Program
    {
        // Converted C++ program to C# program.
        const double OUNCES_PER_METRIC_TON = 35273.92;
        static void Main(string[] args)
        {         
            int ounceInput = 0;
            string enterAgain = "y";
            Console.WriteLine("Basic ounce to metric ton converter.\n");

            while (enterAgain != "n" && enterAgain != "N")
            {
                Console.WriteLine("Please input the weight of the box in ounces: ");
                ounceInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nYou input {ounceInput} ounces.\nThis converts to " + (ounceInput / OUNCES_PER_METRIC_TON) + " Metric tons.\n");
                Console.WriteLine("Would you like to enter a new weight? (y/n): ");
                enterAgain = Console.ReadLine();
                if (enterAgain == "n" || enterAgain == "N")
                {
                    Console.WriteLine("Thank you for using this program");
                }

            }
            return 0;
        }
    }
}
