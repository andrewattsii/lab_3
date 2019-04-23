using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, yesno;
            int number;
            Console.Write("Hello user ! What is your name ? : ");
            name = Console.ReadLine();

            do
            {
                Console.Write($"{name} can you please enter a number between 1 and 100, and I will tell you if it is even or odd :");
                number = int.Parse(Console.ReadLine());


                if (number % 2 == 1 )
                {
                    Console.WriteLine($"{name} {number} is odd");
                }
                else if (number <= 25 )
                {
                    Console.WriteLine($"{name} your number is even and less than 25.");
                }
                else if (number >= 26 && number <= 60)
                {
                    Console.WriteLine($"{name} your number is even");
                }
                else if (number > 60)
                {
                    Console.WriteLine($"{name}'s {number} is even");
                }
                else if (number >= 60 && number % 3 == 0)
                {
                    Console.WriteLine($"{name} you number {number} is odd");
                }

                Console.WriteLine("Do you want to continue ? y/n");
                yesno = Console.ReadLine();
            }

            while (yesno != "n" || number <= 1 && number >= 100);

            

            
               












        }
    }
}
