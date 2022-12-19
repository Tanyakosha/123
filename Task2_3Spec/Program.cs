﻿// Задача необязательная FIZZ BUZZ: Напишите программу, 
// которая выводит на экран числа от 1 до 100. При этом вместо чисел, 
// кратных трем, программа должна выводить слово Fizz, а вместо чисел, 
// кратных пяти — слово Buzz. Если число кратно пятнадцати, 
// то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, 
// но нужно получить наиболее простое и красивое решение.

int a;

for (int i=1; i<101; i++)
{
    a = i;
    if (a % 15 == 0) Console.Write($"FizzBuzz, ");
    else if (a % 5 == 0) Console.Write($"Buzz, ");
    else if (a % 3 == 0) Console.Write($"Fizz, ");
    Console.Write($"{a}, ");
}