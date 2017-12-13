using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpost
{
    public class BlogPost
    {
        public string AuthorName {get; set;}
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublictionDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogPost1 = new BlogPost();
            blogPost1.AuthorName = "John Doe";
            blogPost1.Title = "Lorem Ipsum";
            blogPost1.Text = "Lorem ipsum dolor sit amet.";
            blogPost1.PublictionDate = "2000.05.04";

            BlogPost blogPost2 = new BlogPost();
            blogPost2.AuthorName = "Tim Urban";
            blogPost2.Title = "Wait but why";
            blogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogPost2.PublictionDate = "2010.10.10.";

            BlogPost blogPost3 = new BlogPost();
            blogPost3.AuthorName = "William Turton";
            blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention." +
                             "When I asked to take his picture outside one of IBM’s New York City offices," +
                             "he told me that he wasn’t really into the whole organizer profile thing.";
            blogPost3.PublictionDate = "2017.03.28.";


        }
    }
}
