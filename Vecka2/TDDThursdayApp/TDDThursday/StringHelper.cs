// See https://aka.ms/new-console-template for more information

namespace TDDThursday
{
    public static class StringHelper
    {
        public static Dictionary<char,int> FindVowels(string text)
        {
            Dictionary<char, int> vowels = new Dictionary<char, int> {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 },
                { 'y', 0 },
                { 'å', 0 },
                { 'ä', 0 },
                { 'ö', 0 }
            };
            if (string.IsNullOrWhiteSpace(text)) return vowels;
            foreach (var letter in text.ToLower())
            {
                if (vowels.ContainsKey(letter)) vowels[letter]++;
            }
            return vowels;
        }
    }
}