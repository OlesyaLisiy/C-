﻿// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

int Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

int value;                                     // Объявление переменной
value = Prompt("Введите число > ");            // Вводим значение
int result = value * value;                    // (Переменную можно объявлять и сразу присваивать ей значение) Вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {result}");                 // Вывод результата