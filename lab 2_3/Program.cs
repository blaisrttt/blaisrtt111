
using System.Linq.Expressions;

//try
//{

//    Console.Write("vvedite nomer karti:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("кто по масти:");
//    int y = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 1:
//            Console.WriteLine("piki");
//            break;
//            case 2:
//            Console.WriteLine("bubni");
//            break;
//        case 3:
//            Console.WriteLine("bubi");
//            break;
//            case 4:
//            Console.WriteLine("kresti");
//            break;
//        case 5:
//            Console.WriteLine("piki");
//            break;
//        case 6:
//            Console.WriteLine("bubni");
//            break;
//        case 7:
//            Console.WriteLine("bubi");
//            break;
//        case 8:
//            Console.WriteLine("kresti");
//            break;
//        case 9:
//            Console.WriteLine("piki");
//            break;
//        case 10:
//            Console.WriteLine("bubni");
//            break;
//        case 11:
//            Console.WriteLine("bubi");
//            break;
//        case 12:
//            Console.WriteLine("kresti");
//            break;
//        case 13:
//            Console.Write("koroli");
//            break;
//        case 14:
//            Console.Write("tuz");
//            break;
//        default:
//            Console.WriteLine("net takoi karti");
//            break;
//    }
//    switch (y)
//    {
//        case 1:
//            Console.WriteLine("pik");
//            break;
//        case 2:
//            Console.WriteLine("tref");
//            break;
//        case 3:
//            Console.WriteLine("buben");
//            break;
//        case 4:
//            Console.WriteLine("4ervey");
//            break;
//        default:
//            Console.WriteLine("net takoi masti");
//            break;    
//    }

//}
//catch (Exception a)
//{
//    Console.WriteLine(a.Message);
//}

//try
//{
//    Console.Write("Введите число:");
//    double x = double.Parse(Console.ReadLine());
//    if (x % 100 >= 11 && x % 100 <= 14) Console.WriteLine($"{x} рублей");
//    else
//    {
//        switch (x % 10)
//        {
//            case 1:
//                Console.WriteLine($"{x} рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine($"{x} рубля");
//                break;
//            default:
//                Console.WriteLine($"{x} рублей");
//                break;
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//вариант 20
try
{
    Console.Write("Введите номер варианта:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double a = 0, b = 0, f = 0, y = 0;
    switch (n)
    {
        case 1:
                a = 0.8; b = 2.4; f = Math.Exp(1.5 * a * x);
            break;
        case 2:
                a = 1.2; b = 4.2; f = Math.Exp(2 * a * x);
            break;
        case 3:
                a = 3.4; b = 8.1; f = Math.Exp(3 * a * x);
            break;
    }
    if (x <= a)
        y = Math.Exp(a * x) + f * Math.Pow(Math.Cos(b * x), 2);
    else if (x > a && x <= b * b)
        y = a + Math.Pow(Math.Cos(b * x), 2) - Math.Log(f * x);
    else
        y = Math.Pow(Math.Cos(a + b * x), 2);
    Console.WriteLine($"y = {y:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}