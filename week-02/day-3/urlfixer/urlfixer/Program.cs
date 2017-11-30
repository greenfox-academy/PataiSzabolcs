using System;
using System.Text;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            var urlv = new StringBuilder();


            url = url.Replace("bots", "odds");
            urlv.Append(url);
            urlv = urlv.Insert(5,':');
            url = urlv.ToString();

            //url = urlv;

            //string url2 = "https//www.reddit.com/r/nevertellmethebots";

            //string url1 = "https//www.reddit.com/r/nevertellmethebots";

            Console.WriteLine(url);

            Console.ReadLine();
        }
    }
}