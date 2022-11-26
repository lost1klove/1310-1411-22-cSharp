// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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
                Console.Write($"{matrix[i, j],5}|");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

int[] SummRowsInArray(int[,] matrix)
{
    int length = default;
    if (matrix.GetLength(0) > matrix.GetLength(1)) length = matrix.GetLength(0);
    else length = matrix.GetLength(1);

    int[] array = new int[length];
    int count = 0;
    int minR = count;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        array[count] = summ;
        count++;
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

int NumberOfMinRow(int[] array)
{
    int minSumm = array[0];
    int minCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumm)
        {
            minSumm = array[i];
            minCount = i+1;//выводится именно номер строки, а не индекса
        }
    }
    return minCount;
}

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());


if (row != col)
{
    int[,] matrix2D = CreateMatrixRndArray(row, col, 1, 99);
    int[] rowSummArray = SummRowsInArray(matrix2D);
    int minRow = NumberOfMinRow(rowSummArray);
    // Console.WriteLine("Массив, заполненный случайными целыми числами");
    // Console.WriteLine();
    // PrintMatrix(matrix2D); //проверка корректности заполнения матрицы
    // Console.WriteLine();
    // Console.WriteLine("Суммы элементов каждой строки (1,2...n):"); //проверка корректности заполнения массива
    // PrintArray(rowSummArray);
    // Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов : {minRow}");
}
else Console.WriteLine("Массив не является прямоугольным!");