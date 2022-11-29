// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}


Console.Write("Введите натуральное число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int akkerman = Akkerman(num1, num2);
Console.WriteLine($"Рузельтат выполнения функции Аккермана: {akkerman} ");
