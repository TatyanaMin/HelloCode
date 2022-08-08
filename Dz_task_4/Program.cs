// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB && numberA > numberС)
{
    Console.WriteLine("Nubmer Max = " + numberA);
}

else if(numberB > numberС)
{
    Console.WriteLine("Number Max = " + numberB);
}
else
{
    Console.WriteLine("Number Max = " + numberС);
}
Console.ReadLine();
