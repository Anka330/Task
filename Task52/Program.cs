﻿// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" | ");
    }
}


double[] AverageColumns(int[,] matrix)
{
    int sum = 0;
    double avr = 0;
    double a = 0;
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avr = (sum / matrix.GetLength(0));
        Console.WriteLine(avr);
        a = avr;
        Console.WriteLine(Math.Round(a,2));
        result[j] = Math.Round(avr, 2);
        Console.WriteLine(result[j]);

        // x = (b2 - b1) / (k1 - k2);
        // y = k2 * x + b2;
        // double[] result = { Math.Round(x, 2), Math.Round(y, 2) };
        // return result;

        //result[j] = Math.Round(sum / matrix.GetLength(0), 1);
    }

    return result;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
double[] averageColumns = AverageColumns(array2D);
Console.WriteLine();
PrintArrayDouble(averageColumns);