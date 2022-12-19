// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

if ((x1 == x2) && (y1 == y2)) 
Console.WriteLine($"Прямые совпадают");
else if ((x1==x2) || (y1==y2))
Console.WriteLine($"Прямые параллельны");
else
{
x = (x2 - x1) / (y1 - y2);
y = y1*x+x1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"Пересечение в точке: ({x};{y})");
}