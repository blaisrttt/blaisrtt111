try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());

    bool isInRegion = (y >= 0) && (y <= 2) && (x >= -2) && (x <= 2) &&
                       ((x <= 0 && y >= x + 2) || (x >= 0 && y >= -x + 2));
    Console.WriteLine(isInRegion);
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введено не число!");
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}
//высокий уровень вариант 20