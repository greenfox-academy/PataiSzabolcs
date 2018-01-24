using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTExercises.Services
{
    public class HomeService
    {
        public string SithReverse(string text)
        {
            
            return text;
        }

        public string[] SplitString(string text)
        {
            string[] textArray = text.Split('.');
            return textArray;
        }

        public string YodaReverse(string[] text)
        {
            for (int i = text.Length % 2; i < text.Length; i++)
            {
                string temp = text[i];
                text[i] = text[i + 1];
                text[i + 1] = temp;
            }
            return text.ToString()
                ;
        }
    }
}
