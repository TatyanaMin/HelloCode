/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
using static System.Console;
Clear();
string writeNumbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + writeNumbers(start + 1, end));
}

Console.Write("Введите первое число: ");
int m = int.Parse(ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(ReadLine());
if (m > n)
{
    Console.WriteLine("Задайте первое число больше второго");
}
else
{
    Console.WriteLine(writeNumbers(m, n));
}

 




