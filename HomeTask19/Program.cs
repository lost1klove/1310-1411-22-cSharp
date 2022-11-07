// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палимдромом


Console.Write("Введите пятизначное число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
string Palimdrom(int num)
{
    int palim = 0; //объявляем переменную
    string res =""; //объявляем переменную
    while (num % 10 > 0) // цикл вайл пока изначальное деление с остатком больше 0
    {
    palim = num % 10; // делим введенное на 10 с остатком
    num = num / 10; // введенное на 10 без остатка
    res += palim; //в строковую переменную добавляем получившийся символ
    }   
    return res; //возвращаем
}

string result = Palimdrom(number);
string num = Convert.ToString(number);
if (num == result)
        Console.WriteLine($"Число {number} является палимдромом");
else    
        Console.WriteLine($"Число {number} не является палимдромом");
}
else
{
    Console.WriteLine("Вы ввели некорректное значение");
}
