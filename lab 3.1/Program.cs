try
{
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine());
    int i = i;
    int s = s;
    while (1 <= n)
    {
        s = s * i;
        i = i + 1;
    }
    Console.WriteLine($"Факториап {s}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
