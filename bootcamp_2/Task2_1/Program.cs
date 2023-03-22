int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
// Сложность - O(n)
int sum = 0;
for (int i = 0; i < n; i++)
    sum += array[i];
Console.WriteLine(sum);
// Сложность - O(n)

int numb = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numb; i++)
{
    for (int j = 1; j <= numb; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}
// Сложность - O(n^2)

int[,] matr = new int[numb, numb];
for (int i = 0; i < numb; i++)
{
    for (int j = i; j < numb; j++)
    {
        matr[i, j] = (i + 1) * (j + 1);
        matr[j, i] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < numb; i++)
{
    for (int j = 0; j < numb; j++)
    {
        Console.Write(matr[i,j] + "\t");
    }
    Console.WriteLine();
}
// Сложность - O(n^2/2)