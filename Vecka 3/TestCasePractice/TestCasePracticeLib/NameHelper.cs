namespace TestCasePracticeLib;

using System.Text;

public static class NameHelper
{
    public static string GetInitials(string name)
    {
        if (string.IsNullOrEmpty(name)) return string.Empty;
        var splitNames = name.Split(' ');
        var output = new StringBuilder();
        foreach (var part in splitNames)
        {
            output.Append(part[0].ToString().ToUpper());
        }

        return output.ToString();
    }

    public static string[] GetNames(string name) => !string.IsNullOrWhiteSpace(name) ? name.Split(' ') : new[] { "" };

    public static string GetProperName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return string.Empty;

        var splitNames=name.Split(' ');
        var output = new StringBuilder();
        for(var i = 0; i < splitNames.Length; i++)
        {
            splitNames[i] = splitNames[i][..1].ToUpper() + splitNames[i][1..].ToLower() + " ";
            output.Append(splitNames[i]);
        }
        return output.ToString().Trim();
    }
}