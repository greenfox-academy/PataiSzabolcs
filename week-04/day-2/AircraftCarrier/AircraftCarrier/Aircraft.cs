using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Aircraft
    {
        public int Ammo;
        public int BaseDamage;
        public int MaxAmmo;
        public string Type;
        public int AllDamage;

        public int Fight()
        {
            AllDamage += Ammo * BaseDamage;
            return Ammo * BaseDamage;
        }

        public int Refill(int ammo)
        {
            if (Refill(ammo) < 0)
            {
                this.Ammo = ammo;
                return 0;
            }
            else if (this.Ammo == MaxAmmo)
            {
                return ammo;
            }
            else
            {
                this.Ammo = MaxAmmo;
                return ammo - MaxAmmo;
            }
        }

        public string GetType()
        {
            return Type;
        }

        public string GetStatus()
        {
            return $"Type {Type}, Ammo: {Ammo}, Base Damage: {BaseDamage}, All Damage: {AllDamage} ";
        }

    }
}
