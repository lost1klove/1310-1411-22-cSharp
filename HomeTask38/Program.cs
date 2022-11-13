// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maxElement = Convert.ToInt32(Console.ReadLine());

double[] AddArrayRndDouble(int amount, int min, int max)
{
    double[] array = new double[amount];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double number = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(number, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffIndex(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }
    double res = Math.Round(max - min, 1);
    return res;
}

double[] rndArray = AddArrayRndDouble(num, minElement, maxElement);
double result = DiffIndex(rndArray);
PrintArray(rndArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами в заданном массиве => {result}");
