// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, 
// иначе вывести False.

int countOne = 0;
int countZero = 0;
int[] arr1 = new int[8];
FillArray(arr1);  
string rev_arr = string.Join(", ", arr1);
Console.WriteLine(rev_arr);
CountElements(countOne,countZero);
int[] FillArray(int[] a)
{
    for (int i=0; i<8; i++) // 
{
    a[i] = new Random().Next(0,2);
}
    return a;
}
void CountElements(int a,int b)
{
for (int i=0; i<8; i++)
{
    if (arr1[i] == 0) b++;
    else a++;
}
if (a>b) Console.WriteLine($"TRUE");
else Console.WriteLine($"False");
}