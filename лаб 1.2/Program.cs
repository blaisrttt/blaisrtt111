try
{
    Console.Write("Введите время T: ");
    double T = double.Parse(Console.ReadLine());

    double S = Math.Pow(T, 3) - Math.Sqrt(T);
    double V = 3 * Math.Pow(T, 2) - 1 / (2 * Math.Sqrt(T));

    Console.WriteLine($"Расстояние: {S:F2}");
    Console.WriteLine($"Скорость: {V:F2}");
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}



