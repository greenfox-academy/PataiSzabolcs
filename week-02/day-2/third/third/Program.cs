﻿using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `q`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `q`

            int[] q = new int[4];
            q[0] = 4;
            q[1] = 5;
            q[2] = 6;
            q[3] = 7;

            Console.WriteLine(q[2]);

            Console.ReadLine();
        }
    }
}