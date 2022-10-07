Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;

if (n < 99 && n > -99)
    Console.WriteLine("третьей цифры нет");

else 
{
    while (n > 100 || n < -100)
    {
        m = n % 10;
        n = n / 10;
    }
    
    Console.WriteLine(m);
}

