// Задача 33: Задайте массив. Напишите программу, 
// 1. которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maxElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое необходимо проверить");
int search = Convert.ToInt32(Console.ReadLine());

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

bool SearchNum(int[] array, int searchNum)
{
    int count = 0;
    while (count < array.Length)
    {
        if (array[count] == searchNum)
        {
        return true;
        break;
        }
        count++;
    }
    return false;
}

int[] rndArray = AddArrayRnd(num, minElement, maxElement);
bool searchNumber = SearchNum(rndArray,search);
PrintArray(rndArray);

if (searchNumber)
System.Console.WriteLine($"Число {search} есть в данном массиве");
else
System.Console.WriteLine($"Числа {search} нет в данном массиве");

