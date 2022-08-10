// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


int Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

int N;

N = Prompt("Введите число ");
for (int i = -N; i <= N; i++)
{
    System.Console.WriteLine(i);
}