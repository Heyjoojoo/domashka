void InputMatrixOne(int[,] matrixOne)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrixOne[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputMatrixTwo(int[,] matrixTwo)
{
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrixTwo[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ProductMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] Product = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Product[i, j] = matrixOne[i, j] * matrixTwo[i, j];
            Console.Write($"{Product[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов первой матрицы: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);

int[,] matrixOne = new int[n, m];
int[,] matrixTwo = new int[n, m];
Console.WriteLine("Матрица 1 ");
InputMatrixOne(matrixOne);
Console.WriteLine("Матрица 2 ");
InputMatrixTwo(matrixTwo);
Console.WriteLine("Произведение двух матриц ");
ProductMatrix(matrixOne, matrixTwo);




