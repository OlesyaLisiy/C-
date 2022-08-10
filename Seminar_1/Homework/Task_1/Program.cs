// Задача 1: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value1;
int value2;

value1 = Prompt("Введите первое число ");
value2 = Prompt("Введите второе число ");
if (value1 > value2)
{
    System.Console.WriteLine($"max = {value1}, min = {value2}");
}
else
{
    System.Console.WriteLine($"max = {value2}, min = {value1}");
}

if (value1 == value2)
{
    System.Console.WriteLine("Числа равны");
}