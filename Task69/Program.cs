// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень числа : ");
int degree = Convert.ToInt32(Console.ReadLine());

double DegreeNumber(int num,int deg)
{
    if (deg == 0 ) return 1;
    return num*DegreeNumber(num,deg-1);   
} 

if (degree >= 0)
{
double result = DegreeNumber(number,degree);
Console.WriteLine($"Число {number} в степени {degree} => {result} ");
}
else Console.WriteLine($"Введены некорректные значения! ");