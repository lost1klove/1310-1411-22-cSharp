// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число : ");
long number = Convert.ToInt64(Console.ReadLine());


long TransofrmToThreeDigit(long num)
{
    while (num > 1000)
    {
    long firstMove = num / 10;
    num = firstMove;
    }
    long secondMove = num % 10;
    return secondMove;
    
}
// while (number > 100)
// {
// result = TransofrmToThreeDigit(number);
// number = result;
// }
// result = result % 10;

if (number > 99)
    Console.WriteLine($"Третья цифра числа {number} : " + TransofrmToThreeDigit(number));
else 
    Console.WriteLine($"Третьей цифры в числе {number} нет!");

