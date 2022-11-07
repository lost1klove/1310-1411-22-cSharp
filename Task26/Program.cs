// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SummDigit(int number)
{
    int summdigit = 0;
    while (number != 0)
    {
        number = number / 10;
        summdigit++;
    }
    return summdigit != 0 ? summdigit : 1;
}

int result = SummDigit(num);
Console.WriteLine($"Количество цифр в числе {num} равно {result};");
