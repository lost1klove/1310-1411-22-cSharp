// Задача 60. ...
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2. Напишите программу, которая будет построчно выводить массив, 
// 3. добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3dMatrixRndArray(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    // int rnd = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);
                // matrix[i, j, k] = rnd;
                // rnd+=1;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1)
                    Console.Write($"{matrix[i, j, k],5}({i},{j},{k})|");
                else Console.Write($"{matrix[i, j, k],5}({i},{j},{k})");
            }
            Console.WriteLine("|");
        }
    }
}

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3D = Create3dMatrixRndArray(row, col, depth);
Console.WriteLine("Массив, заполненный случайными целыми числами");
Console.WriteLine();
PrintMatrix(matrix3D);
