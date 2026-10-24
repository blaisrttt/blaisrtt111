try
{
    char[] gay = { 'б', 'у', 'р', 'м', 'а', 'л', 'д', 'а', ';', 'г', 'о', 'л', 'д', 'а', ';', 'а', 'н', 'д', 'р', 'е', 'й', 'в', 'а', 'л', 'е', 'н', 'т', 'и', 'н', 'о', 'в', 'и', 'ч', 'т', 'и', 'г', 'р'};
    int count = 0;
    int i = 0;
    while (i < gay.Length && gay[i] != ':')
    {
        int start = i;
        while (i < gay.Length && gay[i] != ';' && gay[i] != ':')
        {
            i++;
        }
        if (i > start && gay[i - 1] == 'а')
        {
            count++;
        }
        i++;
    }
    Console.WriteLine(count);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//высокий уровень 18 варик