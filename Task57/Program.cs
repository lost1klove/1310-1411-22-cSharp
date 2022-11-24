// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 1, 2, 3     1 встречается 3 раза
// 4, 6, 1     2 встречается 2 раз
// 2, 1, 6     3 встречается 1 раз
//             4 встречается 1 раз
//             6 встречается 2 раза

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(array);
    return array;
}

void PrintArray(int[] array)
{
    int count = 1;
    int elem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i]) count++;
        else
        {
            Console.WriteLine($"Количество {elem} в массиве => {count}");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Количество {elem} в массиве => {count}");
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
    Console.WriteLine("Массив, заполненный случайными целыми числами");
    Console.WriteLine();
    PrintMatrix(matrix2D);
    Console.WriteLine();
    int[] sortArray = MatrixToArray(matrix2D);
    PrintArray(sortArray);
}
else Console.WriteLine("Введите корректные значения!");