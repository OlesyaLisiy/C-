// Задача 4: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num;

num = Prompt("Введите цифру, обозначающую день недели, ");


if (num >= 1 && num <= 5)
{
    Console.WriteLine("Это рабочий день");
}

if (num >= 6 && num <= 7)
{
    Console.WriteLine("Это выходной");
}

if (num < 1 | num > 7)
{
    Console.WriteLine("Вы ввели неверную цифру");
}