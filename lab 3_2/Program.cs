
try
{
    Console.Write("сколько D: ");
    double D = double.Parse(Console.ReadLine());
    double a = 2, b;
    for (int K = 2; ; K++)
    {
        b = 2 + 1.0 / a;
        if (Math.Abs(b - a) < D)
            Console.WriteLine($"K={K} A(K-1)={a:F6} A(K)={b:F6}");
            break;
    }
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}
//вариант 18 средний уровень