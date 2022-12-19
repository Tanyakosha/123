// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что 
// такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.Write($"Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());
int row = new Random().Next(1,10);
int col = new Random().Next(1,10);
int[,] arr = new int[row,col];
bool check = false;

CheckNumbers(FillArray(arr),num);

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
void CheckNumbers(int[,] a,int b)
{
for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            if (a[i,j] == b) 
            {check = true;
            break;
            }
        }
    }
    if (check) Console.WriteLine($"{b} содержится в массиве");
    else Console.WriteLine($"{b} не содержится в массиве");
}