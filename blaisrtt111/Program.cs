//Console.Write("Введите ваше имя:");
//string name = Console .ReadLine();
//Console.WriteLine("Меня зовут "+name);
//Console.WriteLine("Меня зовут {0}",name);
//Console.WriteLine($"Меня зовут {name}");
//Console.Write("Введите х:");
//int x= int.Parse (Console.ReadLine());
//Console.Write("Введите y:");
//int y= Convert.ToInt32 (Console.ReadLine());
//int s = x + y;
//Console.WriteLine($"{x}+{y}={s}");

//float x = 3.7F;
//double y = Math.Pow(x, 7);
//Console.Write("Введите угол в градусах:");
//double angle= double.Parse(Console .ReadLine());
//double y = Math.Sin(angle * Math.PI / 180);
//Console.WriteLine($"y={y:F2}");
//Console.Write("Введите степень числа:");
//double x = double.Parse(Console.ReadLine());
//double y = Math.Exp(7 * x);
//Console.WriteLine($"y={y:f2}");

try
{

    Console.Write("Введите натуральное число n (n > 99): ");
    int n = int.Parse(Console.ReadLine());

    int a = n % 100 / 10;
    int b = n / 100;

    Console.WriteLine($"а) Число десятков: {a}");
    Console.WriteLine($"б) Число сотен: {b}");
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}

//3.30 высокий