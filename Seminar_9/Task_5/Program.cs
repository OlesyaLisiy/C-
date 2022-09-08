// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степенью двойки"
// N = 12 -> “Не является степенью двойки”


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsBinary(int number)
{
    if (number == 1)
    {
        return true;
    }
    return IsBinary(number / 2) && number % 2 == 0;
}

int number = Prompt("Введите число ");
bool result = IsBinary(number);
System.Console.WriteLine(result);