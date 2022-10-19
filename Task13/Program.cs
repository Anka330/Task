// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int thirdNumber = ThirdNumber(num);
    Console.WriteLine($"Третья цифра введенного числа: {thirdNumber}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
int ThirdNumber(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    return number;
}