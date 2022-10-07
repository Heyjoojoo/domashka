Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

n = n/10;

Console.WriteLine(n % 10);