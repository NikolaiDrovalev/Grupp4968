// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое число ");

int numOne = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число ");

int numTwo = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите третье число ");

int numThree = int.Parse(Console.ReadLine()??"0");

if(numOne > numTwo && numThree < numOne)
{
    Console.WriteLine("Первое число самое большое");
}
else if(numTwo > numOne && numThree < numTwo)
{
    Console.WriteLine("Второе число самое большое");
}
else if(numThree > numOne && numTwo < numThree)
{
    Console.WriteLine("Третье число самое большое");
}