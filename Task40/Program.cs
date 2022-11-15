// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С : ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int aside,int bside,int cside)
{
    if (aside < bside+cside && bside < cside+aside && cside<bside+aside) return true;
    return false;
}

bool result = CheckTriangle(a,b,c);

if(result)
Console.WriteLine("Треугольник с такими сторонами может существовать");
else 
Console.WriteLine("Треугольник с такими сторонами не может существовать");
