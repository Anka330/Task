// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if (number == 1) return "xc > 0 и yc > 0";
    if (number == 2) return "xc < 0 и yc > 0";
    if (number == 3) return "xc < 0 и yc < 0";
    if (number == 4) return "xc > 0 и yc < 0";
    return null;
}

string quarter = Quarter(num);

Console.WriteLine(quarter != null 
                    ? $"Указанные координаты соответствуют четверти -> {quarter}"
                    :"Введены некорректные координаты");

