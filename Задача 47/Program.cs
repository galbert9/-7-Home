﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[i, j];

// Рабочий код
// for (i = 0; i < matrix.GetLength(0); i++)
// {
//     for (j = 0; j < matrix.GetLength(1); j++)
//     {

//         matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
//         Console.Write($"\t {matrix[i, j]}");
//     }
//     Console.WriteLine();
// }

// Обертка методом

void FillArray()
{
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
        }
    }
}
FillArray();

void PrintArray()
{
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintArray();