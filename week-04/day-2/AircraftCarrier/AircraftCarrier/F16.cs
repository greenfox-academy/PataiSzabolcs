using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16()
        {
            Type = type;
            MaxAmmo = 8;
            Ammo = 0;
            BaseDamage = 30;
            AllDamage = 0;
        }
    }
}
