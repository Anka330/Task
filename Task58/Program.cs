// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multipleMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            int n = 0;
            while (n < matr2.GetLength(0))
            {
                multipleMatrix[i, j] += matr1[i,n]*matr2[n,j];
                n++;
            }


        }

    }
    return multipleMatrix;

}


Console.Write("Введите количество строк матрицы 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество строк матрицы 2 : ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if (n == k)
{
    int[,] matrix1 = CreateMatrixRndInt(m, n, 0, 9);
    Console.WriteLine("Первая матрица: ");
    PrintMatrix(matrix1);
    Console.WriteLine();

    int[,] matrix2 = CreateMatrixRndInt(k, l, 0, 9);
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(matrix2);
    Console.WriteLine();

    int[,] multMatrix = MultMatrix(matrix1, matrix2); //m,l - размеры новой матрицы
    Console.WriteLine("Произведение двух матриц: ");
    PrintMatrix(multMatrix);


}
else
{
    Console.WriteLine("Матрицу 1 нельзя умножить на матрицу 2. Т.к. число столбцов матрицы 1 не равно числу строк матрицы 2");
}
