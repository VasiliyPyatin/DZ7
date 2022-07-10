// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1, 7] -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

Write("Введите размер матрицы через пробел: ");

string[] sizeS = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);

Write("Введите координаты позиции элемента, через пробел: ");
string[] count = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int irows = int.Parse(count[0]);
int icolumns = int.Parse(count[1]);

if (irows < 0 | irows > ar.GetLength(0) - 1 | icolumns < 0 | icolumns > ar.GetLength(1) - 1)
{
    WriteLine("такого числа в массиве нет");
}
else
{
    WriteLine($"Значение элемента массива = {ar[irows, icolumns]}");
}
            
int[,] GetRandomArray(int row, int column)
{
    int [,] result = new int [row, column];
    for (int i = 0; i<result.GetLength(0); i++) 
    {
        for(int j = 0; j<result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(10,99);
        }
    }
    
    return result;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) 
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Write($"{array [i,j]} ");
        }
        WriteLine();
    }
}



