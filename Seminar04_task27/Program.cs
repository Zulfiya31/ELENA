﻿/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear(); //очистка терминала
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int s = 0;
 while (a > 0)
{
    s = s + a % 10;
    a = a /10 ;
 }
 Console.Write("Сумма цифр в числе равна: " + s);
