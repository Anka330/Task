// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 8)
{
    if (a == 1) Console.Write("Понедельник");
    else if (a == 2) Console.Write("Вторник");
    else if (a == 3) Console.Write("Среда");
    else if (a == 4) Console.Write("Четверг");
    else if (a == 5) Console.Write("Пятница");
    else if (a == 6) Console.Write("Суббота");
    else Console.Write("Воскресенье");
}
else Console.Write("Такого дня недели не существует");


/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник");
    break;

    case 2:
        Console.WriteLine("Вторник");
    break;

    case 3:
        Console.WriteLine("Среда");
    break;

    case 4:
        Console.WriteLine("Четверг");
    break;

    case 5:
        Console.WriteLine("Пятница");
    break;

    case 6:
        Console.WriteLine("Суббота");
    break;

    case 7:
        Console.WriteLine("Воскресенье");
    break;

    default:
        Console.Write("Такого дня недели не существует");
    break;

}*/

