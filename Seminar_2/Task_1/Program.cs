// 1. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int number;
int result;

number = Prompt("Введите число ");
result = number % 10;

{
    System.Console.WriteLine($"Последняя цифра числа {number} равна {result}");
}