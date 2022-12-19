// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write($"Укажите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Укажите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m,n];
for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble();
            Console.Write($"|{Math.Round((100*arr[i,j]), 2)} ");
        }
        Console.WriteLine();
    }