// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int FirstLastNumber(int number)
{
    int firstNumber = number / 100;
    int lastNumber = number % 10;
    return firstNumber*10 + lastNumber;
}

int num = new Random().Next(100, 1000);
Console.WriteLine($"Автоматически сгенерированное число: {num}");
int finanNum = FirstLastNumber(num);
Console.WriteLine($"Число после удаления второй цифры: {finanNum}");

