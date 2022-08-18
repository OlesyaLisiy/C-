// Задача 4: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void SquareTable(int N)
{
    int i = 1;

    while (i <= N)
    {
        System.Console.Write(i * i + " ");
        i++;
    }
}

SquareTable(Prompt("Введите число "));
