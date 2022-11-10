// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

long Degree(long a, long b)
{
    long degr = 1;
    if (b < 0) b = Math.Abs(b);
    for (int i = 0; i < b; i++)
    {
        degr *= a;
    }
    return degr;
}
// в теле метода есть проверка степени и преобразование в натуральную степень, если B<0;
int again = 1;

void DegreeRepeat()
{
    while (again == 1)
    {
        Console.WriteLine("Введите число А");
        long a = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Введите число В");
        long b = Convert.ToInt64(Console.ReadLine());
        //если нужна проверка на положительность числа, то
        // if (b < 0)
        // {
        //     Console.WriteLine("Введите положительное число!");
        // }
        // else 
        // {
        long degree = Degree(a, b);
        Console.WriteLine($"{a}^({b}) = {degree}");
        // }

        Console.WriteLine("Вы хотите возвести еще одно число в степень ? (1 - yes / 0 - no)");
        again = Convert.ToInt32(Console.ReadLine());
    }
}

DegreeRepeat();


