// Задача 18: Напишите программу, которая по
// 1. заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть ,в которой расположена заданная точка :");
string position = Console.ReadLine();

string Position(string pos)
{
    if (pos == "1") return "x > 0, y > 0";
    if (pos == "2") return "x > 0, y < 0 ";
    if (pos == "3") return "x < 0, y < 0";
    if (pos == "4") return "x < 0, y > 0";
    return "Введено некорректное значение";
}

Console.WriteLine(Position(position));
