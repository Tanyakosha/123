// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = new Random().Next(0,10);
int col = new Random().Next(0,10);
int[,] arr = new int[row,col];
double[] sum = new double[col];
MeanSum(FillArray(arr),sum);

int[,] FillArray(int[,] a)
{
for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j = 0; j<a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(0,100);
            Console.Write($"{a[i,j]} ");
        }
        Console.WriteLine();
    }
    return a;
}
void MeanSum(int[,] a,double[] b)
{
for (int j=0;j<arr.GetLength(1);j++)
    {
        for (int i = 0; i<arr.GetLength(0); i++)
        {
            b[j]=b[j]+a[i,j];
        }
        b[j] = Math.Round(b[j]/row, 2);
        Console.WriteLine($"Среднее арифметическое столбца {j+1} равно {b[j]}");
    }
}