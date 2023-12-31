﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

Sort(array);
PrintArray(array);

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

void Sort(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        bool IsSort = true;  //  проверка были ли изменения
        while(IsSort == true)
        {
            IsSort = false;
            for (int j = 1; j < inArray.GetLength(1); j++)
            {
                if(inArray[i,j] > inArray[i,j-1])
                {
                    int temp = inArray[i,j];
                    inArray[i,j] = inArray[i,j-1];
                    inArray[i,j-1]= temp;
                    IsSort = true;
                }
            }
        }
        
    }
}