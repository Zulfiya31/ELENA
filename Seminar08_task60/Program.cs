﻿/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();
Console.Write("Массив: ");
int[,,] massif = new int[2, 2, 2];
FillArray(massif);
PrintIndex(massif);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int j = 0; j < massif.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < massif.GetLength(2); k++)
            {
                Console.Write($"{massif[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}

