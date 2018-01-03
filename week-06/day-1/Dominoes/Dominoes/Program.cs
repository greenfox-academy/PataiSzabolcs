using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();
            foreach (var domino in dominoes)
            {
                Console.WriteLine("[{0}, {1}]", domino.GetValues()[0], domino.GetValues()[1]);
            }
            Console.ReadLine();
        }
        public static void OrderDominoes(List<Domino> dominoes)
        {
            int[] previousDomino = dominoes[0].GetValues();
            Console.Write("[{0}, {1}]", previousDomino[0], previousDomino[1]);
            
            for (int i = 0; i < dominoes.Count - 1; i++)
            {                
                for (int j = 0; j < dominoes.Count; j++)
                {
                    int[] nextDomino = dominoes[j].GetValues();
                    if (nextDomino[0] == previousDomino[1])
                    {
                        Console.Write("[{0}, {1}]", nextDomino[0], nextDomino[1]);
                        previousDomino = nextDomino;
                        break;
                    }
                }
            }

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}