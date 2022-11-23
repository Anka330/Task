// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


int[,] SortStrMatrix(int[,] matrix)
{
    int row = 0;
    int column = 0;
    int max = matrix[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if (matrix[i, j + 1] >= max)
                {
                    max = matrix[i, j + 1];
                    int temp = matrix[row, column];
                    matrix[row, column] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                    j = column;

                    Console.WriteLine($"Макс: {max}");
                    Console.WriteLine($"j: {j}");
                }
            }


        }
    }
    return matrix;
}


Console.Write("Введите количество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, 0, 10);
PrintMatrix(matrix);
Console.WriteLine("");
int[,] sortStrMatrix = SortStrMatrix(matrix);
PrintMatrix(sortStrMatrix);
