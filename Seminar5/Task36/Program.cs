// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
void fillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0, 10);
    }
}

int sumArray (int [] array, int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
            sum = sum + array [i];
            
    }
    return sum;
}

int [] array = new int [10];
fillArray(array);
Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
int sum = 0;
Console.WriteLine($"{sumArray(array, sum)}");

