// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и на выходе 
// 2. показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

int ReturnSecDigit(int num)
{
    int firstMove = num / 10;
    int SecondMove = firstMove % 10;
    return SecondMove;
}

if (number > 99 && number < 1000)
{
    int result = ReturnSecDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} : " + result);
}
else
{
Console.WriteLine("Вы ввели не трехзначное число!");
}