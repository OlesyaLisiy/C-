// **. Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

double Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    double result = double.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

double N;

N = Prompt("Введите число для вывода обратного ему числа ");
    {   
    System.Console.WriteLine($"{1/N}");
    }