// // Задача 9. Напишите программу, которая 
// // 1. выводит случайное число из отрезка [10, 99] и 
// // 2. показывает наибольшую цифру числа.
// // 78 -> 8
// // 12-> 2
// // 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Ваше случайное число : {number}") ;

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10;

// // if (firstDigit > secondDigit)
// // {
// //     Console.WriteLine($"Наибольшая цифра числа : {firstDigit}");
// // }
// // else
// // {
// //     Console.WriteLine($"Наибольшая цифра числа : {secondDigit}");
// // }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} равна: " + maxDigit);

// // Тип метода int etc имя метода MaxDigit аргумент метода-исходные данные(int number)
// // {
// //  return 0;
// //  логика метода
// // }

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(number);

Console.WriteLine($"Наибольшая цифра числа равна: {maxDigit}");



