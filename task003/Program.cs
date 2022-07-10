﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

Write("Введите размер матрицы через пробел: ");

string [] sizeS = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int [,] ar = GetRandomArray(rows, columns);
PrintArray(ar);


for (int i = 0; i < columns; i++)
{
  double averageValue = 0;
  for (int j = 0; j < rows; j++)
  {
    averageValue += ar [j, i];
  }
  averageValue = Math.Round(averageValue / rows, 1);
  WriteLine($"столбца № {i+1} {averageValue}");
}

int [,] GetRandomArray(int row, int column)
{
    int [,] result = new int [row, column];
    for (int i = 0; i<result.GetLength(0); i++) 
    {
        for(int j = 0; j<result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(0,10);
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



// string AverageValue (int [,] ray) // попытка создать метод нахождения среднеарифметического занчения элементов столбцов
// {
// string result = string.Empty;
// for (int i = 0; i < ray.GetLength(0); i++)
// {
//   double averageValue = 0;
//   for (int j = 0; j < i; j++)
//   {
//     averageValue += ar [j, i];
//   }
//   result = $"{Math.Round(averageValue / i, 1)}";

  
//   WriteLine($"столбца № {i+1} {averageValue}");
// }
// return result;
// }