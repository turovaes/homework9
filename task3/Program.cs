Console.WriteLine("Введите два положительных числа: M и N.");
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}