﻿// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 
// 1 до N.

Console.WriteLine("Введите число ");

int numN = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i < numN; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");
    }
}
if (numN % 2 == 0)
{
    Console.Write(numN);
}