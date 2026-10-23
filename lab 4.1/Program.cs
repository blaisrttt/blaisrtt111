
try
{
    Random rnd = new Random();
    Console.Write("Введите количество элементов: ");
    int n = int.Parse(Console.ReadLine());
    int[] mas = new int[n];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        mas[i] = rnd.Next(-9, 10);
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
    int count = 0;
    for (int i = 1; i < mas.GetLength(0) - 1; i++)
    {
        if (mas[i] > mas[i - 1] && mas[i] > mas[i + 1])
            count++;
    }
    Console.WriteLine($"Количество локальных максимумов: {count}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//средний уровень 18 варик

