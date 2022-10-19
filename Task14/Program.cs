// Задача 14. Напишите программу, которая 
// 1. принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да



// Console.WriteLine("Введите число : ");
// int numberA = Convert.ToInt32(Console.ReadLine());


// if (numberA % 7 == 0 && numberA % 23 == 0)
//     Console.WriteLine("Кратно");
// else
//     Console.WriteLine("Не кратно");


bool DivNum(int digit, int num1, int num2)
{
    int result1 = digit % num1;
    int result2 = digit % num2;
    if (result1 == 0 && result2 == 0) return true;
    return false;
}

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7, number2 = 23;

bool result = DivNum(number, number1, number2);

if (result)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно");