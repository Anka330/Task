// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int СountDigits(int num)
{
    int summ = 0;
    int tmp = 0;
    while (num != 0)
    {
        tmp = num % 10;
        summ = summ + tmp;
        num/=10;
    }
    // return summ == 0 ? 1 : count;
    //if (count == 0) count = 1;
    return summ;
}

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigits = СountDigits(number);

Console.WriteLine($"Сумма цифр в числе  {number} равна {countDigits}");