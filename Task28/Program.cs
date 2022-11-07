// Задача 28: Напишите программу, которая
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введтите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Multipl(int num)
{
    int mult = 1;

    for (int i = 1; i <= num; i++)
    {
        mult *= i; // sum = sum + 1
    }

    return mult;
}

if (a > 0)
{
    int multipl = Multipl(a);
    Console.WriteLine($"Произведение чисел от 1 до  {a} = {multipl}");
}
else Console.WriteLine("Введено  некорректное число! Требуется целое положительное число!!!");
