namespace String;

public class String
{
    public static void Main()
    {
        string Name = " ajay,kale,graphics ";
        string Name1 = " ajay,kale,graphics,Designer ";
        string mi = "AJAY";

        Console.WriteLine("StringLenth:- "+Name.Length);
        Console.WriteLine("UpperCase:- "+Name.ToUpper());
        Console.WriteLine("LowerCase:- "+Name.ToLower());
        Console.WriteLine("Trim:- "+Name.Trim());
        Console.WriteLine("Contains a:- "+Name.Contains("a"));
        Console.WriteLine("StartWith a:- "+Name.StartsWith("a"));
        Console.WriteLine("EndWith a:- "+Name.EndsWith("a"));
        Console.WriteLine("SubString 4:- "+Name.Substring(4));
        Console.WriteLine("Replace a->A:- "+Name.Replace("a","A"));
        Console.WriteLine("remove 4:- "+Name.Remove(4));
        Console.WriteLine("insert 6->Kale:- "+Name.Insert(6," Kale"));
        Console.WriteLine("IndexOf y:- "+Name.IndexOf("y"));
        Console.WriteLine("LastIndexOf:- "+Name.LastIndexOf("ajay"));
        
        // Console.WriteLine("Split:- ");
        string[] result = Name.Split(",");
        foreach(string name1 in result)
        {
            Console.WriteLine("Split:-"+name1);
        }
        
    
        string result1 = string.Join("-","Ajay","Kale","Graphics");
        Console.WriteLine("Joint:-"+result1);

        Console.WriteLine("Compare:"+string.Compare(Name,Name1));

        Console.WriteLine("Equals:"+Name.Equals(Name1));

        char[] arr = mi.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Reverse:"+new string(arr));
    }
}