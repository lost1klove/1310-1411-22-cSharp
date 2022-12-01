// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число A: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int NumberSumm(int n, int m)
{
    if (n == m) return n;
    if (n < m) return m + NumberSumm(n, m - 1);
    return m + NumberSumm(n, m + 1);

}

int result = 0;

if (numberN < 0)
{
int newN = 1;
result = NumberSumm(newN, numberM);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна => {result}");
}
if (numberM < 0)
{
int newM = 1;
result = NumberSumm(numberN, newM);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна => {result}");
}
else if (numberM >0 && numberN >0)
{
result = NumberSumm(numberN, numberM);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна => {result}");
}