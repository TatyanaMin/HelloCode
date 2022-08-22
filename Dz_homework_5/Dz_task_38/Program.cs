// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] newarray = new double[10]; 
void FillArray(double[]collection) 
{
     for(int i = 0; i < collection.Length; i++)
    { 
        collection[i] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble() , 1);
    }
}    
void PrintArray(double[] array)   
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]};  ");
    Console.WriteLine();
}
void PrintDifferenceMinMaxElements(double[] array)
{
    double min =  array[0]; 
    double max =  array[0]; 
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {                                      
        if (i == 0) 
        Console.Write("[");
        if (i < array.Length - 1)
        Console.Write(array[i] + ", ");
        else 
        Console.Write(array[i] + "]");
    }
    result = max - min;

    Console.WriteLine($"Значение минимального элемента: {min} ");
    Console.WriteLine($"Значение максимального элемента: {max} ");
    Console.WriteLine($"Разница между максимальным и минимальным значениями элементов = {result} ");
}

FillArray(newarray);
Console.WriteLine();
PrintArray(newarray);
Console.WriteLine();
PrintDifferenceMinMaxElements(newarray);