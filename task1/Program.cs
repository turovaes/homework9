int n = ReadInt("Введите натуральное число ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Вы ввели отрицательное число или 0");
}
Console.WriteLine(Numbers(n, m));

int Numbers(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        Console.Write($"{Numbers(n, m + 1)}, ");
    }
    return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
