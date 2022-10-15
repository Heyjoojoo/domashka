Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int m = 0;
while (n > 1)
{
    m = n%10;
    n = n/10;
    sum = sum + m;
}

Console.WriteLine (sum);