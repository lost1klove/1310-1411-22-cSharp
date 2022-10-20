// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палимдромом


Console.Write("Введите пятизначное число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
string Palimdrom(int num)
{
    int palim = 0;
    string res ="";
    while (num % 10 > 0)
    {
    palim = num % 10;
    num = num / 10;
    res += palim;
    }   
    return res;
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
