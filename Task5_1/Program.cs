// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Укажите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int [] arr = new int[num];
for (int i = 0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(100,1000);
    if (arr[i] % 2 == 0) count++;
}
Console.Write($"В массиве {count} четных чисел");

