using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    public class WordsCounter
    {
        public string Text { get; }
        public Dictionary<string, int> Dictionary
        {
            get
            {
                CreateDictionary(words);
                CountWords(words);
                return dict;
            }
        }

        private Dictionary<string, int> dict = new Dictionary<string, int>();
        private string[] words;

        public WordsCounter(string text)
        {
            Text = text;
            words = SplitWords(Text);
        }

        public string[] SplitWords(string text)
        {
            const string pattern = @"\W+";
            return Regex.Split(text, pattern, RegexOptions.IgnoreCase);
        }

        private void CountWords(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
            }
        }

        private void CreateDictionary(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    continue;
                }
                dict.Add(words[i], 0);
            }
        }
    }
}
