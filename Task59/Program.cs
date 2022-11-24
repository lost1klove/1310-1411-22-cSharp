// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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

(int, int) SearchMinIndex(int[,] matrix)
{
    int minElem = matrix[0, 0];
    var result = (0, 0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= minElem)
            {
                minElem = matrix[i, j];
                result = (i, j);
            }
        }
    }
    return result;
}

int[,] NewSortedMatrix(int[,] matrix, int res1, int res2)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int countHor = 0;
    int countVer = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (countHor == res1) countHor++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (countVer == res2) countVer++;
            {
                newMatrix[i, j] = matrix[countHor, countVer];
            }
            countVer++;
        }
        countVer = 0;
        countHor++;
    }
    return newMatrix;
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
    int[,] matrix2D = CreateMatrixRndArray(row, col, minElement, maxElement);
    var resultNum = SearchMinIndex(matrix2D);
    int result1 = resultNum.Item1;
    int result2 = resultNum.Item2;
    Console.WriteLine("Массив, заполненный случайными целыми числами");
    Console.WriteLine();
    PrintMatrix(matrix2D);
    Console.WriteLine();
    Console.WriteLine($"индекс минимальных элементов => строка : {result1+1}, столбец : {result2+1}");
    Console.WriteLine("Новая отсортированная матрица");
    Console.WriteLine();
    int[,] newMatrix = NewSortedMatrix(matrix2D, result1, result2);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Введите корректные значения!");