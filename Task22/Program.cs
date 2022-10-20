// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

void Sqrt(int num)
{
    int count = 1;
    if (num > 0)
        while (num >= count)
        {
            Console.WriteLine($"{count,4} -> {count * count,4}");
            count++;
        }
    else
    {
        Console.WriteLine("Введите натуральное число!");
    }
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Sqrt(number);
