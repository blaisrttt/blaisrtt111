try
{
    static int[,] ToMatrix(int[] mas)
    {
        int n = (int)Math.Ceiling(Math.Sqrt(mas.Length));
        int[,] matrix = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (k < mas.Length)
                {
                    matrix[i, j] = mas[k];
                    k++;
                }
                else
                {
                    matrix[i, j] = 0;
                }
            }
        }
        return matrix;
    }

    static void Main()
    {
        Random random = new Random();
        int[] mas = new int[16];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = random.Next(10, 50);
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();

        int[,] matrix = ToMatrix(mas);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
catch (Exception a)
{
    Console.WriteLine(a.Message);
}