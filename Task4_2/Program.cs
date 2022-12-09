// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumNum(num);

Console.WriteLine($"Сумма: {sum} ");

int SumNum(int a)
{
while (a > 0)
{
    sum = sum+a%10;
    a = a/10;
}
return sum;
}