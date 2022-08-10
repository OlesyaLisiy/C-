// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница


int Prompt(string message)                     // Функция: на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);             // Вывести сообщение
    string readValue = Console.ReadLine();     // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             // Возвращает результат
}

int value;

value = Prompt("Введите номер дня недели ");
if (value == 1)
{
    System.Console.WriteLine("Понедельник");
}
else
{
    if (value == 2)
    {
        System.Console.WriteLine("Вторник");
    }
    else
    {
        if (value == 3)
        {
            System.Console.WriteLine("Среда");
        }
        else
        {
            if (value == 4)
            {
                System.Console.WriteLine("Четверг");
            }
            else
            {
                if (value == 5)
                {
                    System.Console.WriteLine("Пятница");
                }
                else
                {
                    if (value == 6)
                    {
                        System.Console.WriteLine("Суббота");
                    }
                    else
                    {
                        if (value == 7)
                        {
                            System.Console.WriteLine("Воскресенье");
                        }
                        else
                        {
                            System.Console.WriteLine("Вы ввели не номер дня недели");
                            }
                    }
                }
            }
        }
    }
}