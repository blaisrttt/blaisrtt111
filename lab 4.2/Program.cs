try
{
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());
    if (n <= 0 || m <= 0)
        throw new Exception("n и m должны быть больше 0");
    int[,] mas = new int[n, m];
    int value = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < m; j++)
                mas[i, j] = value++;
        }
        else
        {
            for (int j = m - 1; j >= 0; j--)
                mas[i, j] = value++;
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write($"{mas[i, j],3} ");
        Console.WriteLine();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//высокий ур 18 варик 