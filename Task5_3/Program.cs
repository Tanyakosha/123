// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76 

Console.Write("Укажите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[num];
FillArray(arr);
double min = arr[0]; 
double max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>max) max = arr[i];
    else if (arr[i]<min) min = arr[i];
}
Console.Write($" Разность максимума {Math.Round(max*100,2)}"); 
Console.WriteLine($" и минимума {Math.Round(min*100, 2)} равна {Math.Round((max-min)*100, 2)}");

double[] FillArray(double[] a)
{
for (int i = 0; i<a.Length; i++)
{
    a[i] = new Random().NextDouble();
}
return a;
}