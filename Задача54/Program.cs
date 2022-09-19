// Задать двумерный массив. Написать программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива 

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}");
        }
        Console.WriteLine();
    }
}

void SortRow(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1) - j - 1; k++)
            {
                if (array1[i, k] < array1[i, k + 1])
                {
                    int b = array1[i, k];
                    array1[i, k] = array1[i, k + 1];
                    array1[i, k + 1] = b;
                }
            }
        }
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortRow(array);
PrintArray(array);
