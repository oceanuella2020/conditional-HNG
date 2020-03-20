using System;

namespace conditional_HNG
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            string brand;

            Console.WriteLine("Welcome to  Ocean's Bar. How old are you?");
            age = Int32.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("What brand of Alcohol would you like?");
                brand = Console.ReadLine();
                Console.WriteLine("Have a bottle of "+brand);
            }
            else if(age < 11)
            {
                Console.WriteLine("You're too young to drink. We will contact your Parent/Guardian to come pick you up Kid. ");
            }
            else
            {
                Console.WriteLine("You're too young to drink. Please take your leave.");
            }
        }
    }
}
