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
int[] AddArrayRnd(int amount)
{
    int[] array = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 100);
        for (int j = 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                array[i] += 1;
            }
        }
    }
    return array;
}

int[] SortArrayForUniqNums(int[] array)
{
    int length = array.Length;
    int[] arrayNew = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arrayNew[i] = array[i];
        for (int j = 0; j < length; j++)
        {
            
        }
    }
    return arrayNew;
}

int[] arrayNew = AddArrayRnd(20);
int[] arrayNew2 = SortArrayForUniqNums(arrayNew);
PrintArray(arrayNew);
PrintArray(arrayNew2);