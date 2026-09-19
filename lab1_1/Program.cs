Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double I = (2.33*Math.Log ( Math.Sqrt(1+Math.Cos(y)*Math.Cos(y))))/(Math.Exp(y) + Math.Sin(x)*Math.Sin(x));
Console.WriteLine($"I={I:F2}");


