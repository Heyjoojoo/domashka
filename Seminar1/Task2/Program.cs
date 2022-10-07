Console.WriteLine("Введите три числа: ");
int n = Convert.ToInt32(Console.ReadLine ()); //после команды Convert.ToInt32 всегда возникает какая-то ошибка в файлах, они подсвечены красным и горят ошибки в папке obj
int n2 = Convert.ToInt32(Console.ReadLine ());
int n3 = Convert.ToInt32(Console.ReadLine ());
int nMax = 0;

if (n > n2)
    nMax = n;
else
    nMax = n2;
if (nMax > n3)
{
    Console.WriteLine(nMax + " максимальное число");
}
else
{
    Console.WriteLine(n3 + " максимальное число");
}