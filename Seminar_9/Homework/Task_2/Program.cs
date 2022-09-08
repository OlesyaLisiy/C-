// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumOfNaturalNumbersRow(int min, int max)
{
    if (max < min)
    {
        return 0;
    }
    return min + SumOfNaturalNumbersRow(min + 1, max);
}

int min = Prompt("Введите первое число ");
int max = Prompt("Введите второе число ");

if (min > max)
{
    Console.WriteLine($"Первое число не должно быть больше второго");
}
else
{
    Console.WriteLine($"Сумма элементов равна {SumOfNaturalNumbersRow(min, max)}");
}

