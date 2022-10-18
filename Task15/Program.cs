//Задача 15. Напишите программу, которая принимает на вход цифру,обозначающую день недели, 
//и проверяет, является ли этот день выходным. 
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{

    bool dayWeek = DayWeek(num);
    Console.WriteLine(dayWeek ? "Да" : "Нет");
}
else
{

    Console.WriteLine("Такого дня недели не существует");
}

bool DayWeek(int number)
 {

     return number > 5;
 }