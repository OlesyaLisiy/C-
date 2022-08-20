// Задача 2: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Mult(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    return prod;
}

int num = Prompt("Введите число ");
System.Console.WriteLine($"Произведение от 1 до {num} равно {Mult(num)}");