using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));

            fleet.Things[0].Complete;

        }
    }
}