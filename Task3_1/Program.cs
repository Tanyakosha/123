// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine()??String.Empty;
int num = Convert.ToInt32(a);
int[] arr = new int[a.Length];
int i = 0;
while (num>0)
{
    int b = num%10;
    arr[i] = b;
    num = num/10;
    i++;
}
if ((arr[0]==arr[4]) && (arr[1]==arr[3])){Console.WriteLine($"Число {a} - полиндром");}
else {Console.WriteLine($"Число {a} - не полиндром");}