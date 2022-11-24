// Задача 67: 
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNumbers(number / 10);
}

int sumNumbers = SumNumbers(num);
Console.Write($"Cумма цифр числа {num} = {sumNumbers}");

