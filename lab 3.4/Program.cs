try
{ 
double xStart = -Math.PI / 5;
double xEnd = 6 * Math.PI / 5;
double step = 0.3;
Console.WriteLine("|       x       |       y       |");
Console.WriteLine("----------------------------------");
for (double x = xStart; x <= xEnd + 1e-9; x += step)
{
    double y;
    if (x > 2.5)
    {
        y = 4 * Math.Log(2.3 * x - 1);
    }
    else if (x >= 0 && x <= 2.5)
    {
        y = 1 + 3 * Math.Sin(Math.Abs(1 - x));
    }
    else
    {
        y = Math.Pow(x, 7);
    }

    Console.WriteLine($"| {x,13:F4} | {y,13:F4} |");
}
Console.WriteLine("----------------------------------");
    }
catch (Exception a)
{
    Console.WriteLine(a.Message);
}
//выс ур 18 вар