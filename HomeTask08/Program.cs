// Напишите программу, которая 
// (1)на вход принимает число (N), а 
// (2)на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

if (number > 0)

{
    while (number > count) // если сделать условие number >= count, то выдает и самое максимальное четное число,
    //в случае если N четное. в условии от 1 до N, то есть промежуток.
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine("Введите положительное целое число!");
}