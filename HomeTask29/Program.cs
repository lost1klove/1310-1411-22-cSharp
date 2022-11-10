// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов, заполненный псевдослучайными числами и 
// 2. выводит их на экран.

Console.WriteLine("Input size of array");
int num = Convert.ToInt32(Console.ReadLine());

int[] AddArray(int amount)
{
    int[] array = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[num-1] + "]");
}

int[] addArray = AddArray(num);
PrintArray(addArray);