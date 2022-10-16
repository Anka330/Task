// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число №1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max > b)
    if (max > c)
    {
        Console.Write($"Максимальное число: {a} ");
    }
    else
    {
        Console.Write($"Максимальное число: {c} ");
    }
else
{
    if (c > b)
    {
        Console.Write($"Максимальное число: {c} ");
    }
    else
    {
        Console.Write($"Максимальное число: {b} ");
    }
}