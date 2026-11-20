Hockey[] players = new Hockey[5];
for (int i = 0; i < players.Length; i++)
{
    Console.Write("Введите фамилию:");
    players[i].name = Console.ReadLine()!;
    Console.Write("Введите возраст:");
    players[i].age = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество игр:");
    players[i].games = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество заброшенных шайб:");
    players[i].goals = int.Parse(Console.ReadLine()!);
    if (players[i].age < 25) players[i].group = AgeGroup.Young;
    else players[i].group = AgeGroup.Adult;
    Console.WriteLine();
}

double sum = 0;
for (int i = 0; i < players.Length; i++)
{
    sum += players[i].age;
}
Console.WriteLine($"Средний возраст:{sum / players.Length:F2}");
Console.WriteLine();

for (int i = 0; i < players.Length; i++)
{
    if (players[i].group == AgeGroup.Young) players[i].Print();
}

enum AgeGroup
{
    Young,
    Adult
}

struct Hockey
{
    public string name;
    public int age;
    public int games;
    public int goals;
    public AgeGroup group;
    public void Print()
    {
        Console.WriteLine($"Фамилия:{name}, возраст:{age}, игр:{games}, шайб:{goals}");
    }
}
