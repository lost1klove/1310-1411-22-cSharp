// Задача 50: Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и
// 2. возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента
// в массиве нет

int[,] CreateMatrixRndArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],6}|");
            else Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("|");
    }
}

void PrintSearchNumber(int[,] matrix, int rowNum, int colNum)
{
    int num = default;
    if (matrix.GetLength(0) > rowNum && matrix.GetLength(1) > colNum)
    {
        for (int i = 0; i < rowNum; i++)
        {
            for (int j = 0; j < colNum; j++)
            {
                num = matrix[i, j];
            }
        }
        Console.WriteLine($"Число в строке {rowNum}, столбце {colNum} -> {num}");
    }
    else Console.WriteLine($"Элемента в строке {rowNum}, столбце {colNum} в данном массиве нет");

}

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве (от -99999 до 99999)");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве (от -99999 до 99999)");
int maxElement = Convert.ToInt32(Console.ReadLine());


if (minElement >= -99999 && minElement <= 99999 && maxElement >= -99999 && maxElement <= 99999 && minElement <= maxElement)
{
    Console.WriteLine("Введите номер строки");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int colNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] matrix2D = CreateMatrixRndArray(row, col, minElement, maxElement);
    // PrintMatrix(matrix2D); вывод массива
    Console.WriteLine();
    PrintSearchNumber(matrix2D, rowNumber, colNumber);
}
else Console.WriteLine("Введите корректные значения!");

