// Задача 4: Напишите программу, 
// которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max;
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    max = num1;
}
else 
{
    max = num2;
}
if (max > num3)
{
    Console.WriteLine($"Максимальное число: {max}");
}
else
{
    Console.WriteLine($"Максимальное число: {num3}");
}