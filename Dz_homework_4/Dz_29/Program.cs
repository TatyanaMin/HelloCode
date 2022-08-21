// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// using static System.Console;

// static void WriteArray(int[] array)
//     {
//         for(int i = 0; i<array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//     }

// int[] array = new int[0];
//         while (true)
//         {
//             Console.WriteLine("Введите значение массива ");
//             string meaning = Console.ReadLine();
//             if(meaning != "end")
//             {
//                 int number = Convert.ToInt32(meaning);
//                 int[] newArray = array;
//                 array = new int[array.Length + 1];
//                 for(int i = 0; i < newArray.Length; i++)
//                 {
//                     array[i] = newArray[i];
//                 }
//                 array[array.Length-1] = number;
//             }else
//             {
//                 break;
//             }
//         }
//         WriteArray(array);
//         Пересмотреть семинар и исправить этот код


using System;


class Program
{
    
    static void Main (string[] args)
    {
        string number = Console.ReadLine(); // 1,24,613,124
        string[] array = new string[number.Length];
        int index = 0;
        foreach (var item in number) // 1 , 2 4 , 6 1 3 , 1 2 4
        {
            if(item != ',')
            {
                array[index] += item.ToString();
               
            }else{ 
                index++;
            }
        }
        Console.Write("[ "); // [
        for(int i = 0; i<=index-1; i++)
        {
            Console.Write(array[i] + ", "); // [ 1, 24, 613,
        }
        Console.Write(array[index] + " ]");// [ 1, 24, 613, 124 ]
    }
}
