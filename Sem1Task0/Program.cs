// Задача №0
// Напишите программу, которая на вход принимает число и
// выдаёт его квадрат ( число умноженное само на себя ) 

Console.WriteLine("Введите число ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные были не пустые
if (inputNum != null)
{
    //Парсим введенное число
    //int num = int.Parse(inputNum);
    //Находим квадрат числа
    //int result = num * num;
    //Выводим данные в консоль
    //Console.WriteLine(result);


    Console.WriteLine("Квадрат числа: " + Math.Pow(int.Parse(inputNum), 2));
}