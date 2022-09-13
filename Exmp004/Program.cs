// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// 2, 3, 7 -> 7
Console.Clear();
Console.WriteLine("Условие первое:");
int a = 2, b = 3, c = 7;
int max = 0;
if (a > b) max = a;
else max = b;
if (c > max) max = c;

Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("c = ");
Console.WriteLine(c);
Console.Write("Решение: из трех чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();

// 44 5 78 -> 78
Console.WriteLine("Условие второе:");
a = 44; b = 5; c = 78; max = 0;
if (a > b) max = a;
else max = b;
if (c > max) max = c;

Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("c = ");
Console.WriteLine(c);
Console.Write("Решение: из трех чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();

// 22 3 9 -> 22
Console.WriteLine("Условие третье:");
a = 22; b = 3; c = 9; max = 0;
if (a > b) max = a;
else max = b;
if (c > max) max = c;

Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("c = ");
Console.WriteLine(c);
Console.Write("Решение: из трех чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();