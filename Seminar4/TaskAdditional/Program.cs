Console.Clear();

int n = 1;
int nMax = 0;
int nMax2 = 0;
while (n != 0)
{
    Console.WriteLine("Ну, давай число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    n=m;
    if (nMax < n)
    {
        nMax2 = nMax;
        nMax = n;
    }
    
    if (n==0)
    break;
}

Console.WriteLine($"Второе максимальное число это {nMax2}, что ж ты сам не видишь, Фрэнк?!");