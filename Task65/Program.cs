// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

Console.WriteLine("Введите число натуральное число N : ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число натуральное число M : ");
int numberM = Convert.ToInt32(Console.ReadLine());


void NumsFromNToM(int n, int m)
{
    if (n < m)
    {
        Console.Write($"{n} ; ");
        NumsFromNToM(n + 1, m);
    }
    if (n > m)
    {   
        Console.Write($"{n} ; ");  
        NumsFromNToM(n-1,m);
    }
    if (m==n)
    {
        Console.Write($"{n}  ");
    }

}

NumsFromNToM(numberN, numberM);