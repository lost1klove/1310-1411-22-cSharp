// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultipleMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            newMatrix[i,j]=0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                newMatrix[i,j]+=matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return newMatrix;
}

Console.WriteLine("Введите количество строк матрицы А");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы А");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы В");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы В");
int col2 = Convert.ToInt32(Console.ReadLine());

if (row1 == col2)
{
int[,] firstMatrix2D = CreateMatrixRndArray(row1, col1, 1, 50);
int[,] secondMatrix2D = CreateMatrixRndArray(row2, col2, 1, 50);
int[,] resultMatrix2D = MultipleMatrix(firstMatrix2D,secondMatrix2D);
Console.WriteLine($"Исходные матрицы : ");
PrintMatrix(firstMatrix2D);
Console.WriteLine();
PrintMatrix(secondMatrix2D);
Console.WriteLine();
Console.WriteLine($"Результат умножения матриц : ");
PrintMatrix(resultMatrix2D);
}
else
Console.WriteLine("Матрицы с такими размерами нельзя умножить!"); 