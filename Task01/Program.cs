// Написать программу , которая на вход принимает два числа и проверяет
// является ли первое число квадратом второго
// a=25,b=5 -> да
// a=2,b=10 -> нет
// a=9,b=-3 -> да
// a=-3,b=-9 -> нет
// 1. Принимает два числа
// 2. Проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите число А : ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число В : ");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberA == (numberB * numberB))
{
    Console.Write($"число {numberA} является квадратом числа {numberB}");
}
else if (numberB == (numberA * numberA))
{
    Console.Write($"число {numberB} является квадратом числа {numberA}");
}
else
{
    Console.WriteLine("");
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");
    Console.WriteLine($"число {numberA} не является квадратом числа {numberB}");
}