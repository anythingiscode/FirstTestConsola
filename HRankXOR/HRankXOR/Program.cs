internal class Program
{
    private static void Main(string[] args)
    {
        //List<int> result = new List<int>();
        string result = string.Empty;
        string XOR = string.Empty;
        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
        List<int> t = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
        for (int i = 0; i < s.Count; i++)
        {
            XOR = s[i] == t[i] ? "1" : "0";
            result = result + XOR;
        }
        Console.WriteLine(result);
        Console.ReadKey();
    }
}