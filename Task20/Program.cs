// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = 5.099997545;
// double res = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(res);
// Math.Sqrt(45);

Console.WriteLine("Введите координаты точки 1 :");
Console.Write("X :");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Y :");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 :");
Console.Write("X :");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Y :");
double yb = Convert.ToDouble(Console.ReadLine()); 

double Pifagor(double coordx1,double coordy1, double coordx2,double coordy2)
{
    double rangeX = coordx1-coordx2;
    double rangeY = coordy1-coordy2;
    double rangeZ = Math.Sqrt(rangeX*rangeX+rangeY*rangeY);
    return rangeZ;
}
double result = Pifagor(xa,ya,xb,yb);
double res = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write($"Точка А :{xa},{ya};Точка B : {xb},{yb} => ");
Console.WriteLine (res);

