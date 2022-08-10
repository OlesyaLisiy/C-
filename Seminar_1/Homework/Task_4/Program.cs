// Задача 4: Напишите программу, которая 
// на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int N;

N = Prompt("Введите число ");
for (int i = 2; i <= N; i= i + 2)
{
    System.Console.WriteLine(i);
}