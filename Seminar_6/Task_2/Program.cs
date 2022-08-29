// Задача 1: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsTriangle(int num1, int num2, int num3)
{
    if (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num3)
    {
        return true;
    }
    return false;
}

if (IsTriangle(Prompt("Первая сторона: "), Prompt("Вторая сторона: "), Prompt("Третья сторона: ")))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}
