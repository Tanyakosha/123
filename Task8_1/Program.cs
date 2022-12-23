// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] > array[i, j - 1])
            {
                (array[i, j], array[i, j - 1]) = (array[i, j - 1], array[i, j]);
            }
        }
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                SortElements(array);
            }
        }
    }
    return array;
}
int[,] matrix = CreateArray(3, 4);
PrintArray(matrix);
SortElements(matrix);
Console.WriteLine();
PrintArray(matrix);