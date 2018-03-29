using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    public class WordsCounter
    {
        public string Text { get; } 

        private Dictionary<string, int> dict;

        public WordsCounter(string text)
        {
            Text = text;
        }

        public Dictionary<string, int> GetWords()
        {
            var words = SplitWords(Text);
            return CreateDictionary(words);
        }

        private string[] SplitWords(string text)
        {
            const string pattern = @"\W+";
            return Regex.Split(text, pattern, RegexOptions.IgnoreCase);
        }

        private Dictionary<string, int> CreateDictionary(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (var i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
                else
                {
                    dict.Add(words[i], 1);
                }
            }

            return dict;
        }
    }
}
