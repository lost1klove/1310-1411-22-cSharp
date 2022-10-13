// Напишите программу, которая 
// (1)на вход принимает число и 
// (2)выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число : ");
double numberA = Convert.ToDouble(Console.ReadLine());


if (numberA % 2 == 0)
{
    Console.WriteLine($"Да, число четное.");
}
else 
{
    Console.WriteLine($"Число не является четным.");
}


