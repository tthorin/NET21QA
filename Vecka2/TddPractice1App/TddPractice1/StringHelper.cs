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
            var output = "";
            foreach (var word in words) output += word + " ";
            return output.Trim();
        }
        public static string RemoveWordAt(string text, int pos)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            var words = text.Split(' ').ToList<string>();
            if (pos < 0 || pos > words.Count - 1) return text;
            words.RemoveAt(pos);
            var output = "";
            foreach (var word in words)
            {
                output += word + " ";
            }
            return output.Trim();
        }
        public static string InsertWordAfter(string text, string after, string add)
        {
            return "";
        }
    }
}