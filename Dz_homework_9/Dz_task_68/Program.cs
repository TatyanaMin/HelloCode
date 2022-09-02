/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/
using static System.Console;
Clear();
WriteLine("Введите начальное число m:");
int m = int.Parse(ReadLine());

WriteLine("Введите начальное число n:");
int n = int.Parse(ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");