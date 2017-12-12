using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        public List<Plant> plants;

        public Garden ()
        {
            plants = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            plants.Add(plant);
        }

        public void Watering (double water)
        {
            Console.WriteLine($"Watering with {water}");
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Water += water / plants.Count(p => p.Thirsty == true) * plants[i].Absorbation;
            }
        }

        public void CheckStatus()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Needswater();
            }
        }
    }
}
