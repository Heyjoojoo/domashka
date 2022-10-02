Console.WriteLine("Введите два числа: ");
int n = Convert.ToInt32(Console.ReadLine ()); //после команды Convert.ToInt32 всегда возникает какая-то ошибка в файлах, они подсвечены красным и горят ошибки в папке obj
int n2 = Convert.ToInt32(Console.ReadLine ());

if (n > n2)
{
    Console.WriteLine(n + " максимальное число");
}
if (n < n2)
{
    Console.WriteLine(n2 + " максимальное число");
}
if (n == n2)
{
    Console.WriteLine("Числа равны, максимального нет");
}