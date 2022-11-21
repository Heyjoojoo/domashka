int ResultNumbers(int m, int n)
{
    if (n == m)
        return m;
    return ResultNumbers(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));