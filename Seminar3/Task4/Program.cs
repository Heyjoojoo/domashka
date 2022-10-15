/*
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
*/


Console.Clear();
Console.Write("Введите кол-во кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n];

for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < array.Length - 1; i++)
result[i - 1] = array[i - 1] + array[i] + array[i + 1];

result[result.Length - 2] = array[0] + array[array.Length - 1] + array[array.Length - 2];
result[result.Length - 1] = array[0] + array[1] + array[array.Length - 1];

Console.WriteLine($"[{string.Join(", ", result)}]");
int maxValue = result[0];
for (int i = 1; i < result.Length; i++)
{
if (maxValue < result[i])
maxValue = result[i];
}
Console.WriteLine(maxValue);