// Задача 1 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int digitsCount(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

bool digitsCheck(int count)
{
    if (count == 5)
    {
        return true;
    }
    return false;
}

int getReverse(int num)
{
    int rev = 0;
    while (num > 0)
    {
        int dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    }
    return rev;
}

void isPalindrome(int num, int rev)
{
    if (num == rev)
    {
        System.Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {num} - не палиндром");
    }
}

int num = Prompt("Введите пятизначное число ");

int count = digitsCount(num);

bool isFiveDigits = digitsCheck(count);
if (isFiveDigits)
{
    int rev = getReverse(num);
    isPalindrome(num, rev);
}
else
{
    System.Console.WriteLine($"Число {num} - не пятизначное");
}

