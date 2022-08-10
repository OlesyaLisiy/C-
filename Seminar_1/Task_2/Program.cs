// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да



int Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

int value1;
int value2;
                                    
value1 = Prompt("Введите первое число ");     
value2 = Prompt("Введите второе число ");     
    if (value1 * value1 == value2){
        System.Console.WriteLine($"Число {value2} является квадратом числа {value1}"); 
    } else {
        System.Console.WriteLine($"Число {value2} не является квадратом числа {value1}"); 
    }