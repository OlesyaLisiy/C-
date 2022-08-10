// Задача 3: Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> Четное


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value;

value = Prompt("Введите число для определения, четное ли оно ");

if (value % 2 == 0)
{
    System.Console.WriteLine($"{value} - четное число");
}

else
{
    System.Console.WriteLine($"{value} - нечетное число");
}