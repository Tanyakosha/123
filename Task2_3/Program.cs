// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите индекс дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
   case 1: Console.WriteLine("Понедельник - это не выходной");
   break;
   case 2: Console.WriteLine("Вторник - это не выходной");
   break;
   case 3: Console.WriteLine("Среда - это не выходной");
   break;
   case 4: Console.WriteLine("Четверг - это не выходной");
   break;
   case 5: Console.WriteLine("Пятница - это не выходной");
   break;
   case 6: Console.WriteLine("Суббота - ура! Отдыхаем!");
   break;
   case 7: Console.WriteLine("Воскресенье - продолжаем отдыхать!");
   break;
   default:Console.WriteLine("Вам надо отдохнуть!");
   break;
}