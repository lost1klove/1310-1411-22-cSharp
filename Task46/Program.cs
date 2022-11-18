// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
//    0   1  2   3
//0   1   4  8   19
//1   5  -2  33  -2
//2   77  3  8   1



Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве (от -99999 до 99999)");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве (от -99999 до 99999)");
int maxElement = Convert.ToInt32(Console.ReadLine());

if (minElement >= -99999 && minElement <= 99999 && maxElement >= -99999 && maxElement<= 99999 && minElement <= maxElement)
{
    int[,] matrix2D = CreateMatrixRndArray(row, col, minElement, maxElement);
    PrintMatrix(matrix2D);
}
else Console.WriteLine("Введите корректные значения!");

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




