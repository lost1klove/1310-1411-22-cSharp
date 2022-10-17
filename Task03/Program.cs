// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

char again='y';

while(again == 'y')
{

Console.Write("Введите номер дня недели : ");
int day=Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if(day == 2)
{
    Console.WriteLine("Вторник");
}
else if(day == 3)
{
    Console.WriteLine("Среда");
}
else if(day == 4)
{
    Console.WriteLine("Четверг");
}
else if(day == 5)
{
    Console.WriteLine("Пятница");
}
else if(day == 6)
{
    Console.WriteLine("Суббота");
}
else if(day == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("В неделе только семь дней!");
}
    Console.WriteLine("Вы хотите узнать название еще одного дня недели по номеру ? (y/n)");
    again=Convert.ToChar(Console.ReadLine());
}