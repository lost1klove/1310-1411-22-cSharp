// Напишите программу, которая (1) принимает на вход
// трёхзначное число и на выходе (2)показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = number % 10; // 456 % 10 = 6   456 / 10 = 45

if (number > 99 && number < 1000)
    {
        Console.WriteLine($"Последняя цифра числа = {lastDigit} ");
    }
else
    {
        Console.WriteLine("Введите трехзначное число! ");
    }