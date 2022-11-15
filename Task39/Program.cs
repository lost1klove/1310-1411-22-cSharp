// Задача 39. Напишите программу, которая перевернет одномерный массив

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

void ReverseArray(int[] array)
{
    int len = array.Length - 1;
    for (int i = 0; i < len; i++)
    {
        int temp = array[i];
        array[i] = array[len];
        array[len] = temp;
        len--;
    }
}

int[] rndArray = AddArrayRnd(num, minElement, maxElement);

PrintArray(rndArray);
ReverseArray(rndArray);
PrintArray(rndArray);