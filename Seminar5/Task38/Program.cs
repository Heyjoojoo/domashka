// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Внутренние функции использовать нельзя(Max и Min)
// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble() * 10, 3);
}

double CountEventNumbers(double[] array)
{
double minArray = array[0], maxArray = array[0];
for (int i = 1; i < array.Length; i++) // i = i + 2
{
if (maxArray < array[i])
maxArray = array[i];
else if (minArray > array[i])
minArray = array[i];
}
return maxArray - minArray;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Разница между макс и мин: {CountEventNumbers(array)}");


/*Console.Clear();

void fillArray(double[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 3);
    }
}

void findMax (double [] array, ref double nMax)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>nMax)
        nMax = array[i];
    }
}

void findMin (double [] array, ref double nMin)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<nMin)
        nMin = array [i];
    }
}

double [] array = new double [5];
fillArray(array);
Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
double nMax = array[0];
double nMin = array[0];
findMax(array, ref nMax);
findMin(array, ref nMin);
Console.WriteLine($"Разница между {nMax} и {nMin} = {nMax-nMin}");
*/