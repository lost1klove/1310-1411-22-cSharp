// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

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

void PrintStringMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],10}|");
            else Console.Write($"{matrix[i, j],10}");
        }
        Console.WriteLine("|");
    }
}

double[] ArithmeticMeanArray(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int k = 0;
    for (int j = 0; j < cols; j++)
    {
        double summMean = 0;
        for (int i = 0; i < rows; i++)
        {
            summMean += matrix[i, j];
        }
        summMean /= rows;
        array[k] = Math.Round(summMean, 3);
        k++;
    }
    return array;
}

string[,] CreateArithmeticMeanArray(double[] array) // просто для красоты вывода :)
{
    string[,] matrixNew = new string[2, array.Length];
    int arrLength = 0;
    int i = 0;
    int j = 0;

    for (j = 0; j < array.Length; j++)
    {
        for (i = 0; i < 1; i++)
        {
            matrixNew[i, j] = $"Столбец {j + 1}";
        }
        matrixNew[i, j] = Convert.ToString(array[arrLength]);
        arrLength++;
    }
    return matrixNew;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве (от -999 до 999)");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве (от -999 до 999)");
int maxElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (minElement >= -999 && minElement <= 999 && maxElement >= -999 && maxElement <= 999 && minElement <= maxElement)
{
    int[,] matrix2D = CreateMatrixRndArray(row, col, minElement, maxElement);
    double[] arrayMean = ArithmeticMeanArray(matrix2D);
    string[,] stringMatrixNew = CreateArithmeticMeanArray(arrayMean);
    // PrintMatrix(matrix2D);
    // Console.WriteLine();         //проверка заданного массива
    Console.WriteLine("↓ Среднее арифметическое каждого столбца ↓");
    Console.WriteLine();
    // PrintArray(arrayMean);       //проверка получившегося массива
    // Console.WriteLine();
    PrintStringMatrix(stringMatrixNew);
}
else Console.WriteLine("Введите корректные значения!");