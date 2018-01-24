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
            string[][] wordsInSentences = SplitString(text);
            string finalText = String.Empty;
            for (int i = 0; i < wordsInSentences.Length; i++)
            {
                wordsInSentences[i] = YodaReverse(wordsInSentences[i]);
                if (finalText.Equals(String.Empty))
                {
                    finalText = String.Join(" ", wordsInSentences[i]) + ". " + RandomYodaWords();
                }
                else
                {
                    finalText = finalText + " " + String.Join(" ", wordsInSentences[i]) + ". " + RandomYodaWords();
                }
            }
            return finalText;
        }

        public string[][] SplitString(string text)
        {
            string[] sentences = text.Split(". ");
            sentences[sentences.Length - 1] = sentences[sentences.Length - 1].Remove(sentences[sentences.Length - 1].Length - 1);
            string[][] wordsInSentences = new string[sentences.Length][];
            for (int i = 0; i < sentences.Length; i++)
            {
                wordsInSentences[i] = sentences[i].Split(' ');
            }
            return wordsInSentences;
        }

        public string[] YodaReverse(string[] text)
        {
            for (int i = 0; i < text.Length - text.Length % 2; i += 2)
            {
                string temp;
                if (i == 0)
                {
                    temp = text[i].ToLower();
                    text[i] = text[i + 1];
                    text[i] = text[i].First().ToString().ToUpper() + text[i].Substring(1);
                    text[i + 1] = temp;
                }
                else
                {
                    temp = text[i];
                    text[i] = text[i + 1];
                    text[i + 1] = temp;
                }
            }
            return text;
        }

        public string RandomYodaWords()
        {
            List<string> yodaWords = new List<string>() { "Khmm...", "Hmm...hm.", "Ermm...", "Uhm."};
            Random random = new Random();

            string randomText = yodaWords[random.Next(0, 4)];

            if (random.Next(0, 2) < 1)
            {
                randomText = randomText + " " + yodaWords[random.Next(0, 4)];
            }

            return randomText;
        }
    }
}
