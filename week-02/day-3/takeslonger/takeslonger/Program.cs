﻿using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            var manquote = new StringBuilder();
            manquote = manquote.Append(quote);
            manquote = manquote.Insert(quote.IndexOf("you") , "always takes longer than ");
            quote = manquote.ToString();

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}