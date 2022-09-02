/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от 1 до 2 числа: {sum}"); 
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}

GapNumberSum(m, n, 0);