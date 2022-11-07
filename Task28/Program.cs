// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите положительное число : ");
long num = Convert.ToInt32(Console.ReadLine());

long Factorial(long number)
{
    long count = 1;
    long multiply = 1;
    while (number >= count)
    {
        multiply *= count;
        count++;
    }
    return multiply;
}
if (num >= 1)
{
    long factorial = Factorial(num);
    Console.WriteLine($"Произведение чисел от 1 до {num} равно : {factorial}");
}
else
    Console.WriteLine("Введите положительное число!");
