// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] .


/*void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);*/

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);




