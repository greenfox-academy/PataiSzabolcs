using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        public double Sugar { get; set; }
        public double Money { get; set; }
        public readonly Candy CANDY = new Candy();
        public readonly Lollipop LOLLIPOP = new Lollipop();
        public List<Candy> candies;
        public List<Lollipop> lollipops;
        public const double PRICEOFSUGAR = 0.1;
        public double Raised { get; set; } = 1;

        public CandyShop(double sugar)
        {
            Sugar = sugar;
            candies = new List<Candy>();
            lollipops = new List<Lollipop>();
        }

        public void CreateSweets(Candy CANDY)
        {            
            candies.Add(CANDY);
            Sugar -= CANDY.SugarUse;
        }

        public void CreateSweets(Lollipop LOLLIPOP)
        {            
            lollipops.Add(LOLLIPOP);
            Sugar -= LOLLIPOP.SugarUse;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Inventory: {candies.Count} candies, {lollipops.Count} lollipops, Income: {Money}$, Sugar: {Sugar}gr");
        }

        public void Sell(Candy CANDY, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                candies.Remove(CANDY);
                Money += CANDY.Price * Raised;
            }
        }

        public void Sell(Lollipop LOLLIPOP, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                lollipops.Remove(LOLLIPOP);
                Money += LOLLIPOP.Price * Raised;
            }
        }

        public void BuySugar(double quantity)
        {
            Sugar += quantity;
            Money -= quantity * PRICEOFSUGAR;
        }

        public void Raise (double raise)
        {
            Raised += raise * 0.01;
        }
    }
}
