Console.Clear();

Console.WriteLine("Введите количество кустов: ");
int bush = Convert.ToInt32(Console.ReadLine());
int [] berries = new int[bush];

void FillArray(int[] berries)
{
    int bushindex = 0;
    
    while (bushindex < bush)
    {
        Console.WriteLine($"Введите количество ягод на кусте {bushindex+1}: ");
        berries[bushindex] = Convert.ToInt32(Console.ReadLine());
        bushindex++;
    }
}
FillArray(berries);
Console.WriteLine();

Console.WriteLine("Введите номер куста, у которого находится манипулятор: ");
int index = Convert.ToInt32(Console.ReadLine())-1;

int TotalBerries = 0;

if (index == 0)
    TotalBerries = berries[index] + berries[bush-1] + berries[index+1];
else if (index == bush-1)
    TotalBerries = berries[index] + berries [index - 1] + berries[0];
else
    TotalBerries = berries[index] + berries [index - 1] + berries[index+1];
 
Console.WriteLine ($"Силы небесные, Фрэнк! Здесь манипулятор соберёт аж {TotalBerries} ягод!");
