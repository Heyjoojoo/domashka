Console.Clear();
int [] array = new int [8];

void FillArray (int [] array)
{
    int i = 0;
    while (i<8)
    {
        Console.WriteLine("Введите число: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}
FillArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");