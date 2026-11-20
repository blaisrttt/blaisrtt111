try
{
    static string Swap(string s)
    {
        if (s.Length < 2) return s;
        return s[s.Length - 1] + s.Substring(1, s.Length - 2) + s[0];
    }
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine();
        Console.WriteLine(Swap(s));
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//2 варик базовый