﻿string[,] one = {{" ","/"," "},
                 {"/","|"," "},
                 {" ","|"," "},
                 {" ","|"," "},
                 {" ","|"," "}};

string[,] two = {{" ","-","-"},
                 {"/"," ","/"},
                 {" ","/"," "},
                 {"/"," "," "},
                 {"-","-","-"}};

string[,] three = {{"-","-","-"},
                   {"|","|","|"},
                   {"|","|","|"},
                   {"|","|","|"},
                   {"-","-","-"}};
                   
string[,] DoubleNumber = {{" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "}};

void WriteArray(string[,] array)
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
     
}
