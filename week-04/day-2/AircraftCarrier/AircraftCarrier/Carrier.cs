using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Carrier
    {
        public List<Aircraft> fleet;
        public int Storage;
        public int HP;

        public Carrier(int storage, int hp)
        {
            fleet = new List<Aircraft>();
            Storage = storage;
            HP = hp;
        }
        public void AddAircraft(string type)
        {
            if (type == "F16")
            {
                F16 f16 = new F16();
                fleet.Add(f16);
            }
            else if (type == "F35")
            {
                F35 f35 = new F35();
                fleet.Add(f35);
            }
        }

        public int Fill()
        {

            if (Storage == 0)
            {
                throw new ArgumentOutOfRangeException("No Ammo!");
            }
            else
            {
                for (int i = 0; i < fleet.Count; i++)
                {
                    while (fleet[i].Refill(Storage) != Storage)
                    {
                        if (true)
                        {

                        }
                        Storage = fleet[i].Refill(Storage);
                    }
                        fleet[i].Ammo = Storage - fleet[i].Refill(Storage);
                    Storage = fleet[i].Refill(Storage);
                    return Storage;
                }
            }
            else
            {
                for (int i = 0; i < fleet.Count; i++)
                {
                    fleet[i].Ammo = Storage - fleet[i].Refill(Storage);
                    Storage = fleet[i].Refill(Storage);
                }
                return Storage;
            }
        }
    }
}
