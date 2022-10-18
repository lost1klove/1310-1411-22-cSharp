// Задача 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число А : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В : ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result1 = (numberA * numberA);
int result2 = (numberB * numberB);


if (result1 == numberB || result2 == numberA)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}



//     Console.Write($"число {numberA} является квадратом числа {numberB}");
//     Console.Write($"число {numberB} является квадратом числа {numberA}");
