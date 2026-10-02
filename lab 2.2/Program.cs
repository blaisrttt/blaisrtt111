//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    if (x < 4) Console.WriteLine("Первая область");
//    else Console.WriteLine("Вторая облать");
//}
//catch (Exception a)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y)
//    { max = x; min = y; }
//    else
//    { max = y; min = x; }
//    Console.WriteLine($"max={max}, min={min}");
//}
//catch (Exception a)
//{
//    Console.WriteLine(a.Message);
//}

//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine()); 
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("Не выполняется!");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

using System.ComponentModel.Design;
using System.Linq.Expressions;

//try
//{
//    Console.Write("Введите m:");
//    int n = int.Parse(Console.ReadLine());
//    if (n % 2 == 0 || n % 10 == 7) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//}
//       catch (Exception a)
//{
//            Console.WriteLine(a.Message);
//        

//задача 20 

try
{
    Console.Write("Введите число от 1 до 20:");
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
        Console.WriteLine($"{n} {n} гивна");
    else if (n >= 2 && n <= 4)
        Console.WriteLine($"{n} гривны");
    else
        Console.WriteLine($"{n} гривен");
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}