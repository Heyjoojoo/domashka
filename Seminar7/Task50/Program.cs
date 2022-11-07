void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
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

void ResultMatrix(int[,] matrix)
{
    Console.Write("Введите позицию в строке: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию в столбце: ");
    int l = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == k && j == l)
                Console.Write(matrix[i, j]);

        }

        if (k > matrix.GetLength(0) || l > matrix.GetLength(1))
        {
            Console.Write("Нет такого");
            break;
        }
    }

}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ResultMatrix(matrix);

