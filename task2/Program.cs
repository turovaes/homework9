int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSumFromMtoN(m, n)}");

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int CountSumFromMtoN(int m, int n)
{
    if (m == n) return n;
    else return n + CountSumFromMtoN(m, n - 1);
}
