// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSnail()
{
    // int n = 6;
    Console.Write("Введите длину стороны квадратной матрицы: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[n, n];
    int N = n * n;
    int count = 1;
        int i = 0;
        int j = 0;
    while (count <= N)
    {
        int x = 0;
        while (x < n){
            array[i, j] = count;
            count ++;
            x++;
            j++;
        }
        j -= 1;
        x = 0;
        i++;
        while (x < n - 1){
            array[i, j] = count;
            i++;
            count ++;
            x++;
        }
        i -= 1;
        x = 0;
        j--;
        while (x < n - 1){
            array[i, j] = count;
            j--;
            count ++;
            x++;
        }
        j += 1;
        x = 0;
        i--;
        while (x < n - 2){
            array[i, j] = count;
            i--;
            count ++;
            x++;
        }
        i ++;
        x = 0;
        n -= 2;
        j ++;
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] snail = CreateSnail();
PrintArray(snail);