Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;


for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int p = Convert.ToInt32(Console.ReadLine());
    if (p>0)
        count++;
}

Console.WriteLine(count);