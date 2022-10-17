// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool multiple = Multiple(num);

Console.Write(multiple ? "Кратно 7 и 23" : "Не кратно 7 и 23");

/*Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

Console.WriteLine((Multiple(num, a) && Multiple(num, b)) ? "да" : "нет");


bool Multiple(int first, int second)
{
    return first % second == 0;
}
*/

