// Задача 3: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num = Prompt("Введите число ");
int result;
int value;

while (num > 1000)
{
    result = num / 10;
    num = result;
}

if (num >=100 && num <= 1000)
{
    value = num % 10;
    Console.WriteLine($"{value}");
}
else
{
    Console.WriteLine("Tретьей цифры нет");
}
