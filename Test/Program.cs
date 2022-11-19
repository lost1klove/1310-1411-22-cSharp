string[,] CreateArithmeticMeanArray(double[] array)
{
    string[,] matrixNew = new string[4,array.Length];
    int arrLength = 0;
    int i = 0;
    int j = 0;
        for (j = 0; j < array.Length; j++)
        {   
            for (i = 0; i < array.Length; i++)
            {
                matrixNew[i, j] = Convert.ToString(array[arrLength]);
            }
            matrixNew[i, j] = $"Столбец {j}";
            arrLength++;
        }
    return matrixNew;
}
