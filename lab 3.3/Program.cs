try
{
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i++)
    {
        s += Math.Cos(2 * i * x) / ((2 * i - 1) * (2 * i + 1));
    }
    Console.WriteLine($"s={s:f4}");
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}
//вариант 18
