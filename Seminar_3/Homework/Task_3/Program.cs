// Задача 3. Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void cubesTable(int N)
{
    int i = 1;

    while (i <= N)
    {
        System.Console.Write(i * i * i + " ");
        i++;
    }
}

cubesTable(Prompt("Введите число "));