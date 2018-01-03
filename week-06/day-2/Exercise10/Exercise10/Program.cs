using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxList = new List<Fox>();
            foxList.Add(new Fox("Vuk", "Pallida", "Red"));
            foxList.Add(new Fox("Foxy Lady", "Pallida", "Green"));
            foxList.Add(new Fox("Roka Koma", "Corsac", "Green"));
            foxList.Add(new Fox("Ravaszdi", "Corsac", "Green"));
            foxList.Add(new Fox("Green Pallida Fox", "Pallida", "Green"));

            foxList.Where(f => f.Type == "Pallida" && f.Color == "Green").ToList().ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();
        }
    }
}
