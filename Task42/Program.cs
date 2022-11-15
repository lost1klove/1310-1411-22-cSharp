// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число в десятичной системе, которое хотите преобразовать : ");
int number = Convert.ToInt32(Console.ReadLine());

int[] ConvertToBinary(int num)
{
    int count = 0;
    int reserve = num;
    while (reserve > 0)
    {
        reserve = reserve / 2;
        count++;
    }

    int[] array = new int[count];

    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = num % 2;
        num /= 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Данное число в двоичной системе => [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] convertArray = ConvertToBinary(number);

PrintArray(convertArray);