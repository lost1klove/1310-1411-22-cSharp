// Задача 23. Напишите программу, которая 
// 1.принимает на вход число (N) и 
// 2.выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void IntoCube(int cube)
{
    int count = 1;
    if (cube > 0)
        while (cube >= count)
        {
            double countcube = Math.Pow(count, 3);
            Console.WriteLine($"{count,4} -> {countcube,4}");
            count++;
        }
    else
    {
        Console.WriteLine("Введите натуральное число!");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

IntoCube(number);
