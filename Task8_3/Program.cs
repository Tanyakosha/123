// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateArray(int row, int col, int a)
{
    int[,] arr = new int[row, col];
    // int a = 1;
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0;j < arr.GetLength(1); j++){
            arr[i, j] = a;
            a ++;
            // arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MultMatrix(int row, int col, int[,] array1, int[,] array2)
{
    int[,] array3 = new int[row, col];
    for(int i = 0; i < array3.GetLength(0); i++){
        for (int j = 0;j < array3.GetLength(1); j++){
            if (i == 0 && j == 0) 
            {
                array3[i, j] = (array1[0,0] * array2[0, 0]) + (array1[0,1] * array2[1, 0]);
            }
            if (i == 0 && j == 1)
            {
                array3[i, j] = (array1[0,0] * array2[0, 1]) + (array1[0,1] * array2[1, 1]);
            }
            if (i == 1 && j == 0)
            {
                array3[i, j] = (array1[1,0] * array2[0, 0]) + (array1[1,1] * array2[1, 0]);
            }
            if (i == 1 && j == 1)
            {
                array3[i, j] = (array1[1,0] * array2[0, 1]) + (array1[1,1] * array2[1, 1]);
            }
            
        }
    }    
    return array3;
}

int[,] matrix1 = CreateArray(2, 2, 1);
int[,] matrix2 = CreateArray(2, 2, 5);
int[,] matrix3 = MultMatrix(2, 2, matrix1, matrix2);


PrintArray(matrix1);
// Console.WriteLine();
PrintArray(matrix2); 
PrintArray(matrix3); 