using System;

namespace Domino
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            if ((obj as Domino).Values[0] > Values[0])
            {
                return -1;
            }
            else if ((obj as Domino).Values[0] < Values[0])
            {
                return 1;
            }
            else if ((obj as Domino).Values[1] > Values[1])
            {
                return -1;
            }
            else if ((obj as Domino).Values[1] < Values[1])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}   