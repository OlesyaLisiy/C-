// Задача 2: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int turnPositive(int num)
{
    int number = num;
    if (num < 0)
    {
        number = num * (-1);
    }
    return number;
}

int digitsSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}

int num = Prompt("Введите число ");
int number = turnPositive(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {digitsSum(number)}");