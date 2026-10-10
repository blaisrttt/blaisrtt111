
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int klast = 0;
//int kodd = 0;
//int sumgreater5 = 0;
//long multgreater7 = 0;
//int k05 = 0;
//int last = n % 10;
//while (n != 0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if(temp == last) klast++;
//    if(temp%2==0) kodd++;
//    if (temp > 5) sumgreater5 += temp;
//    if(temp > 7) multgreater7 *= temp;
//    if (temp == 0 || temp == 5) k05++;
//    n/= 10;
//}
//Console.WriteLine($"Кол во 3: {k3}");
//Console.WriteLine($"послед цифра встр:{klast}");
//Console.WriteLine($"кол во четных: {kodd}");
//Console.WriteLine($"сумма больше 5: {sumgreater5}");
//Console.WriteLine($"произведение его цифр больше семи: {multgreater7}");
//Console.WriteLine($"встр цифры 0 и 5: {k05}");

//    for (int i = 1; i <= 9; i++)//внешний цикл
//{ 
//        for (int j = 1; j <= 9; j++)//внут цикл
//    {
//        Console.WriteLine($"{i}*{j}={i * j}");
//    }
//    Console.ReadLine();
//}

//{
//    for (int i = 1; i <= 5; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write(i * 10 + " ");
//        }
//        Console.WriteLine();
//    }
//}

try
{
    Console.Write("S = ");
    double S = double.Parse(Console.ReadLine());
    Console.Write("A = ");
    double A = double.Parse(Console.ReadLine());
    Console.Write("B = ");
    double B = double.Parse(Console.ReadLine());
    int months = 0;
    double expenses = B;
    while (S + A >= expenses)
    {
        S = S + A - expenses;
        expenses *= 1.03;
        months++;
    }
    Console.WriteLine("Месяцев: " + months);
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}

//высокий уровень вариант 18