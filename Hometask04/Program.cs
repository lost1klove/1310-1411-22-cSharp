// Напишите программу, которая 
// 1. принимает на вход три числа и
// 2. выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число : ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
double numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третье число : ");
double numberC = Convert.ToDouble(Console.ReadLine());

double max = numberA;

// while(max < numberB || max < numberC)
// {
    if (max <= numberB)
    {
    max = numberB;
    }
    if (max < numberC)
    {
        max = numberC;
    }    
// }
Console.WriteLine($"Максимальное число = {max}");
