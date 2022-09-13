//Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Условие первое:");
int a = 5, b = 7;
int max = a;
if (a > max) max = a;
else max = b;
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("Решение: из двух чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();

// a = 2 b = 10 -> max = 10
Console.WriteLine("Условие второе:");
a = 2; b = 10; max = a;
if (a > max) max = a;
else max = b;
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("Решение: из двух чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();

// a = -9 b = -3 -> max = -3
Console.WriteLine("Условие третье:");
a = -9; b = -3; max = a;
if (a > max) max = a;
else max = b;
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("Решение: из двух чисел большее max = ");
Console.WriteLine(max);
Console.WriteLine();