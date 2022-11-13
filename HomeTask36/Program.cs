// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SummNotEvenIndex(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i+=2) //    for (int i = 0; i < array.Length; i++)
    {
        // if (array[i]%2 != 0)
        res +=array[i];
    }
    return res;
}

int[] rndArray = AddArrayRnd(num,minElement,maxElement);
int result = SummNotEvenIndex(rndArray);

PrintArray(rndArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях => {result}");