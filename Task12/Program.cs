// Задача 12. Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// 3. то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два числа, кратность которых вы хотите проверить : ");

Console.WriteLine("Введите первое число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

int nekratno = numberA % numberB;

while (numberA != 0 && numberB != 0)
{
    if (numberA % numberB == 0)
    {
        Console.WriteLine("Кратно");
        break;
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток {nekratno}");
        break;
    }
}
Console.WriteLine("Ноль нельзя использовать!");
