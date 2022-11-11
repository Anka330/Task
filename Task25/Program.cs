// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int MultipleAB(int numA, int numB)
{
    int mult = 1;

    for (int i = 1; i <= numB; i++)
    {
        mult = mult * numA; // sum = sum + 1;
    }
    return mult;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0)
{
    int multiplAB = MultipleAB(a, b);
    Console.WriteLine($"Число {a} в натуральной степени {b} равно {multiplAB}");
}
else Console.WriteLine("Введено  некорректное число B! Требуется целое положительное число!!!");