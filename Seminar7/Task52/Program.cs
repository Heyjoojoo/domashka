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

double ReleaseMatrix(int[,] matrix)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            result += matrix[i,j];
        result = result/matrix.GetLength(0);
        Console.Write(Math.Round(result, 2) + " \t");
            
    }
    return result;
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
