namespace SRPClassLib;

public class FileHandler
{
    public string FileName { get; set; }
    
    
    public string Load() => File.Exists(FileName) ? File.ReadAllText(FileName) : "";

    public bool Save(string text)
    {
        return false;
    }
    public bool Save(List<string> rows)
    {
        return false;
    }
}