// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] PointIntersectionTwoLines(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;

    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;

    double[] result = { Math.Round(x, 2), Math.Round(y, 2) };
    return result;
}


Console.Write("Введите значение b1: ");
int bOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int kOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int bTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int kTwo = Convert.ToInt32(Console.ReadLine());

if (kOne == kTwo) Console.WriteLine("Точек пересечения нет."); 

else
{
    double[] pointIntersectionTwoLines = PointIntersectionTwoLines(bOne, kOne, bTwo, kTwo);
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({pointIntersectionTwoLines[0]} {pointIntersectionTwoLines[1]})");
}


