// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли
// первое число квадратом второго

int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");

if (numB * numB == numA)
{
    Console.WriteLine("Первое число квадрат второго");
}
else
{
    Console.WriteLine("Первое число не квадрат второго");
}
