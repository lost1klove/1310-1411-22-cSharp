// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 1. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine("Понедельник - цифра 1");
// Console.WriteLine("Вторник - цифра 2");
// Console.WriteLine("Среда - цифра 3");
// Console.WriteLine("Четверг - цифра 4");
// Console.WriteLine("Пятница - цифра 5");
// Console.WriteLine("Суббота - цифра 6");
// Console.WriteLine("Воскресенье - цифра 7");
// Console.WriteLine();
// пояснение, какие цифры надо вводить
Console.WriteLine("Введите число от 1 до 7 : ");
int number = Convert.ToInt32(Console.ReadLine());

bool DayOfWeek(int num)
{
    if (num >= 1 && num <= 5) return false;
    return true;
    
}

if (number>0 && number<8) //Проверка числа

{
bool dayOfWeek = DayOfWeek(number);
if (dayOfWeek)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Не выходной ");
}

else Console.WriteLine("Вы ввели некорректное число");