// *. Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7


int Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

int N;

N = Prompt("Введите число для вычисления его модуля ");
if (N > 0)
{
    System.Console.WriteLine($"{N}");
} else
    {   
    System.Console.WriteLine($"{-N}");
    }
