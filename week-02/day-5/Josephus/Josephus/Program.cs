using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int[] array = new int[number];
            int place = 0;

            for (int i = 0; i < number; i++)
            {
                array[i] = i + 1;
            }
            
            for (int i = 0; i < number - 1; i++)
            {
                int kill = 1;
                if (place + kill > number - 1)
                {
                    kill = kill - (place + kill);
                    while (array[place + kill] == 0)
                    {
                        kill++;
                        if (place + kill > number - 1)
                        {
                            kill = kill - (place + kill);
                            //place = place + kill;
                        }
                        //else
                        //{
                        //    place = place + kill;
                        //}

                    }
                }
                else
                {
                    while (array[place + kill] == 0)
                    {
                        kill++;
                        if (place + kill > number - 1)
                        {
                            kill = kill - (place + kill);
                        }
                    }
                }
                array[place + kill] = 0;
                place = place + kill;
                int jump = 1;
                if (place + jump > number - 1)
                {
                    jump = jump - (place + jump);
                    while (array[place + jump] == 0)
                    {
                        jump++;
                        if (place + jump > number - 1)
                        {
                            jump = jump - (place + jump);
                            //place = place + jump;
                        }
                        //else
                        //{
                        //    place = place + jump;
                        //}

                    }
                }
                else
                {
                    while (array[place + jump] == 0)
                    {
                        jump++;
                        if (place + jump > number - 1)
                        {
                            jump = jump - (place + jump);
                            //place = place + jump;
                        }
                        //else
                        //{
                        //    place = place + jump;
                        //}

                    }
                }
                place = place + jump;
            }
            foreach (int element in array)
            {
                if (element != 0)
                {
                    Console.WriteLine("The winning seat is " + element + ".");
                }
            }
            Console.ReadLine();
        }
    }
}
