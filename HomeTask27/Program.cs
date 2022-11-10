// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.


Console.WriteLine("Введите число : ");
long num = Convert.ToInt64(Console.ReadLine());
 
 long Summ(long number)
 {
    long summary = 0;
    while ( number != 0)
    {
    summary += number % 10;
    number = number / 10;
    }
    return summary;
 }

 long summ = Summ(num);

    Console.WriteLine($"Сумма чисел данного числа равна : {summ}");