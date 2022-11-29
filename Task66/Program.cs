// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NaturalNumbersMN(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM + NaturalNumbersMN(numM - 1, numN);
}


Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    int sumMN = NaturalNumbersMN(m, n);
    Console.Write($"Cумма чисел от {m} до {n} = {sumMN}");
}
else
{
    {
        int sumMN = NaturalNumbersMN(n, m);
        Console.Write($"Cумма чисел от {m} до {n} = {sumMN}");
    }
}
