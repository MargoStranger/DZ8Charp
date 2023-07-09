// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк в 1 матрице: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в 1 матрице: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк во 2 матрице: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во 2 матрице: ");
int columns2 = int.Parse(Console.ReadLine()!);

while (columns1 != rows2)
{
    Console.WriteLine("Количество столбцов 1 матрицы должно быть ровно количеству строк 2 матрицы");
    Console.Write("Введите количество столбцов в 1 матрице: ");
    columns1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество строк во 2 матрице: ");
    rows2 = int.Parse(Console.ReadLine()!);
}

int[,] array1 = GetArray(rows1, columns1, 0, 11);
PrintArray(array1);

Console.WriteLine();

int[,] array2 = GetArray(rows2, columns2, 0, 11);
PrintArray(array2);

Console.WriteLine("Новая матрица = умножению предидущих:");
PrintArray(GetProductMatrix(array1, array2));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetProductMatrix(int[,] Array1,  int[,] Array2)
{
    int[,] NewArray = new int [Array1.GetLength(0), Array2.GetLength(1)];
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            for (int k = 0; k < Array1.GetLength(1); k++)
            {
                NewArray[i,j] += Array1[i,k]*Array2[k,j];
            }
        }
    }
    return NewArray;
}