// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int count = 2;
while (count <= a)
{
    Console.Write($"{count} ");
    count += 2;
}
if (a < 2)
{
    Console.Write($"Четных чисел от 1 до {a} нет");
}



