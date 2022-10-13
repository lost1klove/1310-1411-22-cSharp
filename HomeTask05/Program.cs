// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее,
// 3. а какое меньшее.

Console.WriteLine("Введите первое число : ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberA < numberB)
    {
        Console.WriteLine("");
        Console.WriteLine($"Число {numberB} большее");
        Console.WriteLine($"Число {numberA} меньшее");
    }
else 
    {
        Console.WriteLine("");
        Console.WriteLine($"Число {numberA} большее");
        Console.WriteLine($"Число {numberB} меньшее");
    }