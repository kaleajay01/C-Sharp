namespace String;

public class String
{
    public static void Main()
    {
        string Name = "  ajay  ";

        Console.WriteLine("StringLenth:- "+Name.Length);
        Console.WriteLine("UpperCase:- "+Name.ToUpper());
        Console.WriteLine("LowerCase:- "+Name.ToLower());
        Console.WriteLine("Trim:- "+Name.Trim());
        Console.WriteLine("Contains a:- "+Name.Contains("a"));
        Console.WriteLine("StartWith a:- "+Name.StartsWith("a"));
    }
}