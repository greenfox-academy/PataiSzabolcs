using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("Give me the number of the girls:");
            string input1 = Console.ReadLine();
            int girls = int.Parse(input1);

            Console.WriteLine("Give me the number of the boys:");
            string input2 = Console.ReadLine();
            int boys = int.Parse(input2);

            if (girls == boys && boys + girls > 20)
            {
                Console.WriteLine("The party is excelent!");
            }

            if (girls != boys && boys + girls > 20)
            {
                Console.WriteLine("Quite cool party!");
            }

            if (boys + girls < 20)
            {
                Console.WriteLine("Average party");
            }

            if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
        }
    }
}