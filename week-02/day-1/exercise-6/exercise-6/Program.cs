using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int codingHours = 6;
            int weeks = 17;
            int workingDays = 5;
            int totalCoding = codingHours * weeks * workingDays;
            Console.WriteLine($"An attendee spends {totalCoding} hours with coding in a semester.");
            int workHours = 52;
            double average = (double)codingHours * (double)workingDays / (double)workHours * 100;
            Console.WriteLine($"An attendee spends {average}%  of his or her working time with coding in the semester.");
            Console.ReadLine();
        }
    }
}