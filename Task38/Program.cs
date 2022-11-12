// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayDouble(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        double num = rnd.NextDouble() * (100 - -100) + -100;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(" | ");
    }
    Console.WriteLine("]");
}


double MaxNumArr(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    return maxNum;
}


double MinNumArr(double[] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    return minNum;
}


double DiffMaxMin(double maxNum, double minNum)
{
    return Math.Round(maxNum - minNum, 1);
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayDouble(length);
PrintArray(array);
double max = MaxNumArr(array);
double min = MinNumArr(array);

Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Миниммальный элемент массива: {min}");

double diffMaxMin = DiffMaxMin(max, min);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diffMaxMin}");


