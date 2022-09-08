// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if ((m != 0) && n == 0)
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int m = Prompt("Введите первое число ");
int n = Prompt("Введите второе число ");

if (m < 0 || n < 0)
{
    Console.WriteLine($"Числа не должны быть отрицательными");
}
else
{
    Console.WriteLine($"{AckermannFunction(m, n)}");
}





