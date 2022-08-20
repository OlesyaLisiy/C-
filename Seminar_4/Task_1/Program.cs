// Задача 1: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int findSum(int numberA)
{
    int sum = 0;
    for (int i = 0; i <= numberA; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sumGaus(int numberA)
{
    int sum = (int)((numberA + 1) * (numberA / 2.0));
    return sum;
}

int numberA = Prompt("Введите число для суммы ");
System.Console.WriteLine($"Cумма чисел по Гауссу от 1 до {numberA} равна {sumGaus(numberA)}");
System.Console.WriteLine($"Cумма чисел от 1 до {numberA} равна {findSum(numberA)}");
