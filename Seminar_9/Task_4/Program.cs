// Задача 4: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Power(int number, int power)
{
    if (power == 0)
    {
        return 1;
    }
    return number * Power(number, power - 1);
}


int number = Prompt("Введите число ");
int power = Prompt("Введите степень числа ");
int result = Power(number, power);
System.Console.WriteLine(result);