﻿// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");

int numEven = int.Parse(Console.ReadLine()??"0");

if (numEven % 2 == 0)
{
    Console.WriteLine("Число " + numEven + " чётное");
}
else
{
    Console.WriteLine("Число " + numEven + " нечётное");
}