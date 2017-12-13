using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post_it
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }
        static void Main(string[] args)
        {
            PostIt postIt1;
            postIt1.BackgroundColor = "orange";
            postIt1.TextColor = "blue";
            postIt1.Text = "Idea 1";
            PostIt postIt2;
            postIt2.BackgroundColor = "pink";
            postIt2.TextColor = "black";
            postIt2.Text = "Awesome";
            PostIt postIt3;
            postIt3.BackgroundColor = "yellow";
            postIt3.TextColor = "green";
            postIt3.Text = "Superb";
        }
    }
}
