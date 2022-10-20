// Задача 21. Напишите программу, которая 
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A :");
Console.Write("X :");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Y :");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Z :");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B :");
Console.Write("X :");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Y :");
double yb = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Z :");
double zb = Convert.ToDouble(Console.ReadLine());

double Coordinate3D(double coordXA,double coordYA, double coordXB,double coordYB,double coordZA,double coordZB)
{
    double rangeX = coordXA-coordXB;
    double rangeY = coordYA-coordYB;
    double rangeZ = coordZA-coordZB;
    double range = Math.Sqrt(rangeX*rangeX+rangeY*rangeY+rangeZ*rangeZ);
    return range;
}

double result = Coordinate3D(xa,ya,xb,yb,za,zb);
double res = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write($"Точка А :{xa},{ya},{za};Точка B : {xb},{yb},{zb} => ");
Console.WriteLine (res);
