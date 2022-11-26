// Задача 62: Заполните спирально массив 4 на 4.
// sx = -sstepVertical ;
// sstepVertical = sx;
void PrintSpiraleMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)//можно изменить направление заполнения, поменяв j на i
    {
        Console.Write("|");
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (i < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] SpiraleMatrix(int[,] matrix)
{

    int stepHorizontal = -1;
    int stepVertical = 0;
    int value = 1;
    int rows = 1;
    int cols = 1;
    int maxRows = matrix.GetLength(0);
    int maxCols = matrix.GetLength(1)-1;
    

    while (maxRows >= 0 && maxCols >=0)
    {
        for (int i = 1; i <= maxRows; i++)
        {
            matrix[stepHorizontal + rows * i, stepVertical] = value;
            value++;       
        }
        stepHorizontal = stepHorizontal + rows * maxRows;
        rows = -rows;
        maxRows--;
        for (int j = 1; j <= maxCols; j++)
        {
            matrix[stepHorizontal, stepVertical + cols * j] = value;
            value++;
        }
        stepVertical = stepVertical + cols * maxCols;
        cols = -cols;
        maxCols--;
    }
    return matrix;
}


int[,] mtrx = new int[4,4];

mtrx = SpiraleMatrix(mtrx);
PrintSpiraleMatrix(mtrx);
