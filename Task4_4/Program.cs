// Задача 26 Hard необязательная. Напишите программу, которая принимает на вход целое или дробное число 
// и выдает количество цифр и чисел
// 452 -> 3
// 82 -> 2
// 9.012 -> 4
Console.Write("Введите число: ");
var num = Convert.ToDouble(Console.ReadLine());
int i=0;
while (num>0)
{
    num = num/10;
    i++;
}
Console.WriteLine(num);
Console.WriteLine(i);