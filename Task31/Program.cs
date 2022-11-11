// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и 
// 3. положительных элементов массива. Например, 
// в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

int[] GetSumPositiveNegotiveElem(int[] array)
{
    int sumPositive = 0;
    int sumNegotive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegotive += array[i];
    }
    return new int[]{sumPositive,sumNegotive};
}

int[] addArray = AddArrayRnd(num, minElement, maxElement);
int[] sumArray = GetSumPositiveNegotiveElem(addArray);
PrintArray(addArray);
Console.WriteLine($"Суммы положительных элементов в массиве = {sumArray[0]}");
Console.WriteLine($"Сумма отрицательных элементов в массиве = {sumArray[1]}");