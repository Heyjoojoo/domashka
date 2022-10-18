// SuperStep

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

int[] arrayResult = new int[n];
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayResult[i] = array[n - k + i];
    for (int i = 0; i < n - k; i++)
        arrayResult[k + i] = array[i];

    Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}
else
{
    k = k * (-1);
    for (int i = 0; i < k; i++)
        arrayResult[n - k + i] = array[i];
    for (int i = 0; i < n - k; i++)
        arrayResult[i] = array[k + i];

    Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}