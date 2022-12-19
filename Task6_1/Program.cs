// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write($"Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

CheckNumbers(num);
Console.WriteLine($"Пользователь ввел {count} положительных чисел");

int CheckNumbers(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.Write($"Введите число {i} : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
        Console.WriteLine();
    }
    return count;
}