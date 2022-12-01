// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int NumbersSumm(int num)
{
    
    if (num==0) return 0;
    return num%10 + NumbersSumm(num/10);
    
} 
int result = NumbersSumm(number);
Console.WriteLine($"Сумма чисел числа {number} равна => {result}");