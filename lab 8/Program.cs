//using Microsoft.VisualBasic;
//using System.Data;

//DateTime data4 = new DateTime();
//Console.WriteLine(data4);
//DateTime dateNow = DateTime.Now;
//Console.WriteLine(dateNow);
//DateTime date2 = new DateTime(2026, 11, 21);
//Console.WriteLine(date2);
//DateTime date3 = new DateTime(2026, 11, 21, 12, 37, 45);
//Console.WriteLine(date3);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(dateNow.Year);
//Console.WriteLine(dateNow.Month);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.Date);
//Console.WriteLine(dateNow.Minute);
//Console.WriteLine(dateNow.Hour);
//Console.WriteLine(dateNow.Second);
//Console.WriteLine(dateNow.Millisecond);
//Console.WriteLine(dateNow.Nanosecond);
//Console.WriteLine(dateNow.Kind);
//DateTime date4 = DateTime.Parse("2027-5-09");
//Console.WriteLine(data4);

////операции
//Console.WriteLine(date4.Add(new TimeSpan(34,12,78)));
//Console.WriteLine(data4.AddDays(8));
//Console.WriteLine(data4.AddDays(-7));
//Console.WriteLine(data4.AddHours(80));
//Console.WriteLine(data4.AddTicks(85453543));
//Console.WriteLine(data4.Subtract(DateTime.Now));





//месяцы между датами 1 задание
Console.Write("Введите первую дату (гггг-мм-дд): ");
DateTime date1 = DateTime.Parse(Console.ReadLine()!);
Console.Write("Введите вторую дату (гггг-мм-дд): ");
DateTime date2 = DateTime.Parse(Console.ReadLine()!);

int months = (date2.Year - date1.Year) * 12 + (date2.Month - date1.Month);
Console.WriteLine($"Месяцев между датами: {months}");
Console.WriteLine();


//база 16 варик


//стиральная машина 2 задание
Console.Write("Введите длительность стирки в минутах: ");
int minutes = int.Parse(Console.ReadLine()!);

DateTime start = DateTime.Now;
Console.WriteLine($"Стирка началась: {start.ToString("g")}");

DateTime end = start.AddMinutes(minutes);
Console.WriteLine($"Стирка закончится: {end.ToString("g")}");
Console.WriteLine($"Год окончания: {end.Year}, месяц: {end.Month}, день: {end.Day}");
Console.WriteLine($"Часы: {end.Hour}, минуты: {end.Minute}");

