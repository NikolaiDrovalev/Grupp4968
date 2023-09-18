// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
int numOne = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число ");
int numTwo = int.Parse(Console.ReadLine()??"0");

if (numOne > numTwo)
{
    Console.WriteLine("Первое число больше, а второе меньше"); 
}
else
{
    Console.WriteLine("Второе число больше, а первое меньше");
}