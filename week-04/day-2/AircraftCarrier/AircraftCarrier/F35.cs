using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            Type = type;
            MaxAmmo = 12;
            Ammo = 0;
            BaseDamage = 50;
            AllDamage = 0;
        }
    }
}
