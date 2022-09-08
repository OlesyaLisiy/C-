// Задача 3: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр. 
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return SumDigits(number / 10) + number % 10;

}

int number = Prompt("Введите число ");
int sum = SumDigits(number);
System.Console.WriteLine(sum);