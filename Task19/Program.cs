// Задача 19: Напишите программу, которая
// принимает на вход пятизначное число 
// и проверяет является ли оно палиндромом.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 100000 && num > 9999)
{
    int palindrom = Palindrom(num);
    Console.WriteLine(palindrom == num ? $"Да" : "Нет");
}
else
{
    Console.WriteLine("Введены некорректные данные!");
}


int Palindrom(int number)
{
    int count = 10000;
    int newNum = 0; // число наоборот от введенного пользователем
    int lastNum = 0; //последняя цифра числа
    while (number >= 1)
    {
               
        lastNum  = number % 10;
        number = number / 10;
        newNum = lastNum * count + newNum;
        count = count/10;
    }
    
    return newNum;
}