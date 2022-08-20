// Задача 1: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int raiseToAPower(int num1, int num2)
{
    int toAPower = 1;
    for (int i = 1; i <= num2; i++)
    {
        toAPower = toAPower * num1;
    }
    return toAPower;
}

int num1 = Prompt("Введите первое число ");
int num2 = Prompt("Введите второе (натуральное) число ");
if (num2 <= 0)
{
    Console.WriteLine("Число введено некорректно ");
}
else
{
    Console.WriteLine(raiseToAPower(num1, num2));
}