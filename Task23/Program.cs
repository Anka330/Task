// Задача 23: Напишите программу, которая 
// принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    NumCube(num);
}
else
{
    Console.WriteLine("Введены некорректные данные!");
}


void NumCube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i,4}  |  {i * i * i,4}");
    }
}