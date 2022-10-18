// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите положительное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int secondNumber = SecondNumber(num);
    Console.WriteLine($"Вторая цифра введенного числа: {secondNumber}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
int SecondNumber(int number)
{
    int finalNumber = number / 10 % 10; return finalNumber;
}