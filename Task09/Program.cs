// 9. Напишите программу, которая:
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру числа.
// 
// 78 -> 8
// 12-> 2
// 85 -> 8

/*int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99: {num}");

int firstDigit = num / 10; // 78 / 10 = 7
int secontDigital = num % 10; // 78 %1 0 = 8

int res = firstDigit;
if (secontDigital > firstDigit) res = secontDigital;
Console.WriteLine($"Наибольшая цифра числа {num} = {res}");

if (firstDigit > secontDigital) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {num} = {secontDigital}");

int result = firstDigit > secontDigital ? firstDigit : secontDigital; //тернарный оператор
Console.WriteLine($"Наибольшая цифра числа {num} = {result}"); */



// int max = Math.Max(firstDigit, secontDigital); Встроенный метод нахождения максимального числа
// Console.WriteLine($"Наибольшая цифра числа = {num} = {max}");

/*Код преподавателя:
int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

int firstDigit = num / 10; // 78 / 10 = 7
int secondDigit = num % 10; // 78 % 10 = 8

int res = firstDigit;
if(secondDigit > firstDigit) res = secondDigit;
Console.WriteLine($"Наибольшая цифра числа {num} = {res}");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

Console.Write($"Наибольшая цифра числа {num} = ");
Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);
*/

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99: {num}");

int MaxDigit(int number) //имя метода с большой буквы
{
    int firstDigit = number / 10; // 78 / 10 = 7
    int secondDigit = number % 10; // 78 % 10 = 8
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int maxDigit = MaxDigit(num); // вызываем метод

Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");