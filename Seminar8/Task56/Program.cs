void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int ReleaseMatrix(int[,] matrix)
{
    int[] Summa = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Summa[i] += matrix[i, j];
        }
        Console.Write($"{Summa[i]} \t");
    }

    int temp = Summa[0];
    int ShowRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (Summa[i] < temp)
            temp = Summa[i];
        ShowRow = i + 1;
    }
    return ShowRow;

}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
while (n != m)
{
    Console.Write("Введите кол-во строк и столбцов(кол-во строк=кол-во столбцов): ");
    num = Console.ReadLine().Split(' ');
    n = int.Parse(num[0]);
    m = int.Parse(num[1]);
}
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(ReleaseMatrix(matrix));




