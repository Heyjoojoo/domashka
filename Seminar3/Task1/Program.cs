Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 100000)
{
    Console.WriteLine ("Это число не подходит, попробуйте снова: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n%10 == n/10000 && (n/10)%10 == (n/1000)%10)
    Console.WriteLine("Это палиндром");
else 
    Console.WriteLine("Это не палиндром");