// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.Write("Введите целое число : ");
int number = Convert.ToInt32(Console.ReadLine());

int square = (number*number);

Console.Write($"Квадрат числа {number}= {square}");




