// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("");
int size = 10;
int min = 1;
int max = 100;

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
int[] copyArray = CopyArray(arr);
PrintArray(copyArray);

