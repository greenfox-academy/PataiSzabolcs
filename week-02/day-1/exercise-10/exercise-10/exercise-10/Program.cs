using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string myName = "Szablcs";
            int myAge = 27;
            double myHeight = 1.73;
            bool married = true;
            Console.WriteLine
                (
                "My name  is " + myName +
                ", I am " + myAge + " years old, "
                + myHeight + " meters tall" +
                "and it is " + married + " that I am married."
                );

            Console.ReadLine();
        }
    }
}