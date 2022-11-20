// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayRndInt(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите число {i + 1}, затем нажмите Enter: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;
}


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(m);
int countPositiveNum = CountPositiveNum(arr);
Console.WriteLine($"Количество чисел введенных пользователем больше нуля = {countPositiveNum}");


