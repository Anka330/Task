// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Quarter(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i,4}   {i * i,4}"); //($"{i,4}   {i * i},4") 4 - Чтоб красиво выводилось в консоль
    }
}

if (num > 0)
{
Quarter(num);
}
else
{
Console.WriteLine("Введены некорректные данные!");
}

