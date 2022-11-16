// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
Console.WriteLine("Прямые параллельны и не могут пересекаться!");
else
{
double[] Intersection(double kOne, double bOne, double kTwo, double bTwo)
{
    double x = (bTwo - bOne) / (kOne - kTwo);
    double y = kOne * x + bOne;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] resultArray = Intersection(k1,b1,k2,b2);

Console.Write("Прямые пересекаются в точке с координатами : ");
PrintArray(resultArray);
}
