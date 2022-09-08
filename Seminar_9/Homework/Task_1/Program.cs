// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ShowNaturalEvenNumbersRow(int min, int max)
{
    if (min > max)
    {
        return;
    }
    if (min % 2 == 0)
    {
        System.Console.Write($"{min} ");
    }
    ShowNaturalEvenNumbersRow(min + 1, max);
}

int min = Prompt("Введите первое число ");
int max = Prompt("Введите второе число ");

if (min > max)
{
    Console.WriteLine($"Первое число не должно быть больше второго");
}
else
{
    ShowNaturalEvenNumbersRow(min, max);
}
