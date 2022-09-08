// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsPrimeNumber(int number, int divider)
{
    if (divider == 1)
    {
        return true;
    }
    return IsPrimeNumber(number, divider - 1) && number % divider > 0;
}

int number = Prompt("Введите число ");
bool result = IsPrimeNumber(number, number - 1);
System.Console.WriteLine(result);