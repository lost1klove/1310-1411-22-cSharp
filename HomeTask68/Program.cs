// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return Akkerman(a - 1, 1);
    return Akkerman(a - 1, Akkerman(a, b - 1));
}
if (numberA >= 0 && numberB >= 0)
{
    int akkerman = Akkerman(numberA, numberB);
    Console.WriteLine($"Значение функции Аккермана => {akkerman}");
}
else
{
    Console.WriteLine("Введите неотрицательные значения А и В !");
}