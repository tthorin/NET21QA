// -----------------------------------------------------------------------------------------------
//  MagicNumbers.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System.Collections;
using System.Text;
// ReSharper disable UnusedMember.Global

namespace TestCasePracticeLib;

public enum NumberWords
{
    Noll,
    Ett,
    Två,
    Tre,
    Fyra,
    Fem,
    Sex,
    Sju,
    Åtta,
    Nio
}

public static class NumberMagic
{
    public static int MagicSum(int number) => number.ToString().Sum(num => int.Parse(num.ToString()));

    public static string NumWords(int number)
    {
        var output = new StringBuilder();
        foreach (var num in number.ToString())
        {
            output.Append((NumberWords) int.Parse(num.ToString())).Append(' ');
        }

        return output.ToString().TrimEnd();
    }

    public static string Roman(int number)
    {
        if (number is < 1 or > 3999) return "";

        Dictionary<int, string> numberToRoman = new()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        var output = new StringBuilder();
        foreach (var (key, value) in numberToRoman)
        {
            while (number >= key)
            {
                output.Append(value);
                number -= key;
            }
        }

        return output.ToString();
    }

    public static string NumbersToWords(int number)
    {
        var numberWords = new Dictionary<int, string>
        {
            {900, "nio hundra "},
            {800, "åtta hundra "},
            {700, "sju hundra "},
            {600, "sex hundra "},
            {500, "fem hundra "},
            {400, "fyra hundra "},
            {300, "tre hundra "},
            {200, "två hundra "},
            {100, "ett hundra "},
            {90, "nittio "},
            {80, "åttio "},
            {70, "sjuttio "},
            {60, "sextio "},
            {50, "femtio "},
            {40, "fyrtio "},
            {30, "trettio "},
            {20, "tjugo "},
            {19, "nitton"},
            {18, "arton"},
            {17, "sjutton"},
            {16, "sexton"},
            {15, "femton"},
            {14, "fjorton"},
            {13, "tretton"},
            {12, "tolv"},
            {11, "elva"},
            {10, "tio"},
            {9, "nio"},
            {8, "åtta"},
            {7, "sju"},
            {6, "sex"},
            {5, "fem"},
            {4, "fyra"},
            {3, "tre"},
            {2, "två"},
            {1, "ett"}
        };
        var numberString = number.ToString();
        List<string> nums = new();
        ExtractThreeNumberGroupings(numberString, nums);

        var output = new StringBuilder();
        DeconstructNumberListIntoWords(nums, numberWords, output);

        return output.ToString().Trim();
    }

    private static void DeconstructNumberListIntoWords(List<string> nums, Dictionary<int, string> numberWords, StringBuilder output)
    {
        while (nums.Count > 0)
        {
            var numberFromString = int.Parse(nums[0]);
            DeconstructListItem(numberWords, output, numberFromString);

            AddProperGroupWord(nums, output);
            nums.RemoveAt(0);
        }
    }

    private static void AddProperGroupWord(ICollection nums, StringBuilder output)
    {
        output.Append(nums.Count switch
        {
            4 => " miljarder ",
            3 => " miljoner ",
            2 => " tusen ",
            _ => ""
        });
    }

    private static void DeconstructListItem(Dictionary<int, string> numberWords, StringBuilder output, int numberFromString)
    {
        while (numberFromString > 0)
        {
            foreach (var (key, value) in numberWords)
            {
                if (numberFromString < key) continue;
                output.Append(value);
                numberFromString -= key;
            }
        }
    }

    private static void ExtractThreeNumberGroupings(string numberString, IList<string> nums)
    {
        while (numberString.Length > 0)
        {
            if (numberString.Length >= 3)
            {
                nums.Insert(0, numberString[^3..]);
                numberString = numberString[..^3];
            }
            else
            {
                nums.Insert(0, numberString);
                numberString = "";
            }
        }
    }
}