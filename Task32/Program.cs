// Задача 32: Напишите программу замена элементов массива: 
// 1. положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]




Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maxElement = Convert.ToInt32(Console.ReadLine());


int[] AddArrayRnd(int amount, int min, int max)
{
    int[] array = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] InversionArray(int[] array)
{
    int[] inversArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        inversArray[i] = array[i] * (-1); 
    }
    return inversArray;
}

int[] rndArray = AddArrayRnd(num, minElement, maxElement);
int[] reverseArray = InversionArray(rndArray);

PrintArray(rndArray);
PrintArray(reverseArray);