int Factorial(int n)
{
    int x = 1;
    for (int i = 1; i < n; i++)
    {
        x *= i;
    }
    return x;
}


void Pascal(int[,] matrix, int n)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= n - i; j++)
        {
            Console.Write(" ");
        }
        
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];
Factorial(n);
Pascal(matrix, n);


