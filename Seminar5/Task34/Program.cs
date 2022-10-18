//  Задайте массив заполненный случайными 
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет 
//  количество чётных чисел в массиве.

Console.Clear();
void fillArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(100,1000);
}

int showNumbers (int[] array, int numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2==0)
        numbers = numbers +1;
    }
    return numbers;
}

int[] array = new int [20];
fillArray(array);
Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
int numbers = 0;
Console.WriteLine($"{showNumbers(array, numbers)}");
