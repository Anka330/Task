// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if (number == 1) return "xc > 0 && yc > 0";
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return null;
}

string quarter = Quarter(num);

Console.WriteLine(quarter == null
            ? $"Введены некорректные координаты"
            : "Указанные координаты соответствуют четверти -> {quarter}");

