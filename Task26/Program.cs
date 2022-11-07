// Задача 26: Напишите программу, 
// которая принимает на вход число 
// и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int СountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
        num /= 10;
    }
    return count == 0 ? 1 : count;
    //if (count == 0) count = 1;
    //return count;
}

Console.Write("Введтите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigits = СountDigits(number);

Console.WriteLine($"В числе  {number} содержится {countDigits} цифр");
