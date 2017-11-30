using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentHours = 14;
            //int currentMinutes = 34;
            //int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            Console.WriteLine("Please give me the current time in the following form: \"HH:MM:SS\". The program will fill the : for you.");
            ConsoleKeyInfo UserInput = Console.ReadKey();
            int hour1 = int.Parse(UserInput.KeyChar.ToString());
            ConsoleKeyInfo UserInput2 = Console.ReadKey();
            int hour2 = int.Parse(UserInput.KeyChar.ToString());
            int hours = hour1 * 10 + hour2;

            Console.Write(":");

            ConsoleKeyInfo UserInput3 = Console.ReadKey();
            int minute1 = int.Parse(UserInput3.KeyChar.ToString());
            ConsoleKeyInfo UserInput4 = Console.ReadKey();
            int minute2 = int.Parse(UserInput3.KeyChar.ToString());
            int minutes = minute1 * 10 + minute2;
            Console.Write(":");

            ConsoleKeyInfo UserInput5 = Console.ReadKey();
            int second1 = int.Parse(UserInput5.KeyChar.ToString());
            ConsoleKeyInfo UserInput6 = Console.ReadKey();
            int second2 = int.Parse(UserInput5.KeyChar.ToString());
            int seconds = second1 * 10 + second2;

            int totalSeconds = 24 * 60 * 60;
            int secondsLeft = totalSeconds - (hours * 60 * 60) - (minutes * 60) - seconds;

            Console.WriteLine("\nYou have only " + secondsLeft + " seconds until midnight. Hurry up!");
            Console.ReadLine();
        }
    }
}