// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Укажите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] arr = new int[num];
FillArray(arr);
OddSum(arr);
Console.Write($"Cумма элементов, стоящих на нечётных позициях: {sum}");

int[] FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-1000, 1000);
    }
    return a;
}
int OddSum(int[] b)
{
    for (int j = 1; j < (b.Length / 2); j = j + 2)
    {
        sum = sum + b[j];
    }
    return sum;
}