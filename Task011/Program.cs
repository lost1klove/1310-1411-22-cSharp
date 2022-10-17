// Задача 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ваше случайное число : {number}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return (firstDigit*10)+thirdDigit;
}


int result = DelSecondDigit(number);

Console.WriteLine($"Полученное число : {result}");

