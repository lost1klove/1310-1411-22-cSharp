// Напишите программу, которая 
// (1)на вход принимает число (N), а 
// (2)на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

if (number > 0 )

{
    while (number >= count)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine("Введите положительное целое число!");
}