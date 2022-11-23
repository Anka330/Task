// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2      sum = 14
// 5 9 2 3      sum = 19 
// 8 4 2 4      sum = 18
// 5 2 6 7      sum = 20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumStrMatrix(int[,] matr)
{

    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            array[i] = sum;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.WriteLine($"Сумма элементов в строке {i + 1} = {array[i]} ");
            else Console.WriteLine($"Сумма элементов в строке {i + 1} = {array[i]}");
        }
    }
}

int MinSumElemStr(int[] array)
{
    int strMin = array[0];
    int position = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < strMin)
        {
            strMin = array[i];
            position = i;
        }

    }
    return position + 1;

}


Console.Write("Введите количество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumStrMatrix = SumStrMatrix(matrix);
PrintArray(sumStrMatrix);

int minSumElemStr = MinSumElemStr(sumStrMatrix);
Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой элементов: {minSumElemStr}");

