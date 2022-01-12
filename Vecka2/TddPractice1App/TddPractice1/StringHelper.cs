// See https://aka.ms/new-console-template for more information

namespace TddPractice1
{
    using System.Linq;
    public static class StringHelper
    {
        public static string GetWord(string text, int x, char separator = ' ')
        {
            if (string.IsNullOrEmpty(text) || x < 0) return "";
            text = text.Trim();
            var words = text.Split(separator).ToList<string>();
            while (words.Contains(""))
            {
                words.Remove("");
            }

            return x >= words.Count ? words[^1] : words[x];
        }

        public static List<string> StringToList(string text, char separator = ' ')
        {
            return text == null ? new List<string>() : text.Split(separator).ToList<string>();
        }
        public static string RemoveWord(string text, string remove)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(remove)) return "";
            var words = text.Trim().Split(' ').ToList<string>();
            if (words.Contains(remove)) words.Remove(remove);

            return ListToString(words);
        }
        public static string RemoveWordAt(string text, int pos)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            var words = text.Split(' ').ToList<string>();
            if (pos < 0 || pos > words.Count - 1) return text;
            words.RemoveAt(pos);
            return ListToString(words);
        }
        public static string InsertWordAfter(string text, string after, string add)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";
            else if (string.IsNullOrWhiteSpace(after) || string.IsNullOrWhiteSpace(add)) return text;

            var words = text.Trim().Split(' ').ToList<string>();
            var idx = words.IndexOf(after);
            if (idx >= 0)
            {
                if (idx == words.Count - 1) words.Add(add);
                else words.Insert(idx + 1, add);
            }
            return ListToString(words);
        }
        public static string SwapWords(string text, int word1, int word2)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";
            var words = text.Trim().Split(' ').ToList<string>();
            if (word1 < 0 || word1 > words.Count - 1 || word1 == word2) return text;
            if (word2 < 0 || word2 > words.Count - 1) return text;

            var swap = words[word1];
            words[word1] = words[word2];
            words[word2] = swap;

            return ListToString(words);
        }
        private static string ListToString(List<string> words)
        {
            var output = string.Empty;
            foreach (var word in words) output += word + " ";
            return output.Trim();
        }
    }
}