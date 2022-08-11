// Задача 1: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num;
int num1;
int result;

num = Prompt("Введите трехзначное число ");

if (100 <= num && num < 1000)
{
    num1 = num / 10;
    result = num1 % 10;
    System.Console.WriteLine($"Вторая цифра числа {num} - это {result}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}