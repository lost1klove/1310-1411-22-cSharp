// Задача 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число А : ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число В : ");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberA == (numberB * numberB) && numberB/numberA==0)
{
    Console.Write($"число {numberA} является квадратом числа {numberB}");
}
// else if (numberB == (numberA * numberA))
// {
//     Console.Write($"число {numberB} является квадратом числа {numberA}");
// }