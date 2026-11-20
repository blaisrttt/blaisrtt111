using OurLibrary;

Random random = new Random();
int[,] matrix = new int[5, 6];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        matrix[i, j] = random.Next(-5, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов в [-2;3]: {OurClassLibrary.SumInRange(matrix)}");
