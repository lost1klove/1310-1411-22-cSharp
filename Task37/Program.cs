// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// 2. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplyIndex(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;
    int[] multiplyArray = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        multiplyArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) multiplyArray[multiplyArray.Length - 1] = array[array.Length/2];

    return multiplyArray;
}

int[] rndArray = AddArrayRnd(num, minElement, maxElement);

int[] multiplyArray = MultiplyIndex(rndArray);

PrintArray(rndArray);
PrintArray(multiplyArray);