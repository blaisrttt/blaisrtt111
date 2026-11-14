try
{
    Console.Write("Введите натуральное число: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите основание p (2..9): ");
    int p = int.Parse(Console.ReadLine());
    if (n <= 0 || p < 2 || p > 9)
    {
        Console.WriteLine("Неверный ввод!");
        return;
    }
    int[] digits = new int[32];
    int count = 0;
    int temp = n;
    while (temp > 0)
    {
        digits[count] = temp % p;
        temp = temp / p;
        count++;
    }
    Console.Write("Результат: ");
    for (int i = count - 1; i >= 0; i--)
    {
        Console.Write(digits[i]);
    }
    Console.WriteLine();
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}
