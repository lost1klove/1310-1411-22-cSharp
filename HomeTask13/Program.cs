// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число : ");
long number = Convert.ToInt64(Console.ReadLine());
long result = 0;
long numberLast = number;

long TransofrmToThreeDigit(long num)
{
    long firstMove = num / 10;
    return firstMove;
}
while (number > 1000)
{
result = TransofrmToThreeDigit(number);
number = result;
}
result = result % 10;

if (number > 99)
    Console.WriteLine($"Третья цифра числа {numberLast} : " + result);
else 
    Console.WriteLine($"Третьей цифры в числе {numberLast} нет!");
