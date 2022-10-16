// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.Write("Введите число №1: ");
int a = Convert.ToInt32(Console.Readline());
Console.Write("Введите число №2: ");
int b = Convert.ToInt32(Console.Readline());

if (a == b * b)
{
    Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}