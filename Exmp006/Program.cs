// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Вопрос: является ли четным число 4?");
double a = 4;
if (a %2 == 0) Console.WriteLine("Ответ: число 4 является четным");
else Console.WriteLine("Ответ: число 4 является нечетным O_O");
Console.WriteLine();

Console.WriteLine("Вопрос: является ли четным число -3?");
a = -3;
if (a %2 == 0) Console.WriteLine("Ответ: число -3 является четным O_O");
else Console.WriteLine("Ответ: число -3 является нечетным");
Console.WriteLine();

Console.WriteLine("Вопрос: является ли четным число 7?");
a = 7;
if (a %2 == 0) Console.WriteLine("Ответ: число 7 является четным O_O");
else Console.WriteLine("Ответ: число 7 является нечетным");
Console.WriteLine();

Console.WriteLine("Вопрос: какие из чисел являются четными: 4, -3 или 7?");
Console.Write("Введите одно из чисел: 4, -3 или 7:   ");
double b = Console.Read();
if (b %2 == 0) Console.WriteLine("Ответ: число, которое Вы ввели является четным.");
else Console.WriteLine("Ответ: число, которое Вы ввели является нечетным.");
Console.WriteLine();