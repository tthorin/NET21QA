namespace TestCasePracticeLib
{
    using System.Text;

    public class NameHelper
    {
        public string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return String.Empty;
            var splitNames = name.Split(' ');
            var output = new StringBuilder();
            foreach (var part in splitNames)
            {
                output.Append(part[0].ToString().ToUpper());
            }

            return output.ToString();
        }

        public string[] GetNames(string name) => name != null ? name.Split(' ') : new string[] { "" };

        public string GetProperName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return String.Empty;

            var splitNames=name.Split(' ');
            var output = new StringBuilder();
            for(int i = 0; i < splitNames.Length; i++)
            {
                splitNames[i] = splitNames[i][..1].ToUpper() + splitNames[i][1..].ToLower() + " ";
                output.Append(splitNames[i]);
            }
            return output.ToString().Trim();
        }
    }
}