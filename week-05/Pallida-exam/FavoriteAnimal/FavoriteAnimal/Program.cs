using System;
using System.IO;

namespace FavouriteAnimals
{
    public class FavouriteAnimals
    {
        public static void Main(string[] args)
        {
            // The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them
            CollectFavorite(args);
        }

        public static void CollectFavorite(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
            }
            else
            {
                string[] favorites = File.ReadAllLines(@"C:\Users\Szabi\Desktop\greenfox\PataiSzabolcs\week-05\Pallida-exam\FavoriteAnimal\FavoriteAnimal\favorites.txt");
                StreamWriter writer = new StreamWriter(@"C:\Users\Szabi\Desktop\greenfox\PataiSzabolcs\week-05\Pallida-exam\FavoriteAnimal\FavoriteAnimal\favorites.txt", true);
                for (int i = 0; i < args.Length; i++)
                {
                    if (!Array.Exists(favorites, element => element == args[i]))
                    {
                        writer.WriteLine(args[i]);
                    }
                }
                writer.Close();
            }
        }
    }
}
