// Задача 2: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value1;
int value2;
int value3;

value1 = Prompt("Введите первое число ");
value2 = Prompt("Введите второе число ");
value3 = Prompt("Введите третье число ");

int maxValue = value1;

if (value2 > maxValue)
{
    maxValue = value2;
}

if (value3 > maxValue)
{
    maxValue = value3;
}

{
    System.Console.WriteLine($"max = {maxValue}");
}
