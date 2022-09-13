// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
int N = 5;
double number = 1;
int count = 0;

Console.WriteLine("Выводим четные числа: ");
Console.WriteLine("в промежутке от 1 до N");
Console.Write("N = ");
Console.WriteLine(N);

while (count < N)
{
    if (number %2 == 0) 
    {
    //Console.Write("Ответ: четное ");
    //else Console.Write("Ответ: нечетное ");
    //Console.Write("number = ");
    Console.WriteLine(number);
    }
    number = number + 1;
    count = count + 1;
}

Console.WriteLine();
Console.WriteLine("в промежутке от 1 до N");
N = 8; number = 1; count = 0;
Console.Write("N = ");
Console.WriteLine(N);

while (count < N)
{
    if (number %2 == 0) 
    {
    //Console.Write("Ответ: четное ");
    //else Console.Write("Ответ: нечетное ");
    //Console.Write("number = ");
    Console.WriteLine(number);
    }
    number = number + 1;
    count = count + 1;
}