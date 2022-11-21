int ResultNumbers(int m, int n)
{
    if (m == 0)
        return n+1;
    if (n == 0)
        return ResultNumbers (m-1,1);
    return ResultNumbers(m -1, ResultNumbers(m, n - 1));
}


Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));