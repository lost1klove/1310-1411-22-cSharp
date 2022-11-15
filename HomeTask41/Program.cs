// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел.
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел вы хотите ввести ? : ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через пробел : ");

int[] InputArray(int amount)
{
    int[] array = new int[amount];

    string[] input = Console.ReadLine().Split(' ');

    for (int i = 0; i < amount; i++)
    {
        array[i] = int.Parse(input[i]);
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

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        count++;
    }
    return count;
}

int[] newArray = InputArray(amount);
int countEven = EvenNumbers(newArray);

PrintArray(newArray);
if (countEven<5)
Console.WriteLine($"Пользователь ввел {countEven} числа больше 0");
else
Console.WriteLine($"Пользователь ввел {countEven} чисел больше 0");