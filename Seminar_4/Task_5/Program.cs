// Принять число N. Напечатать N знаков от 1, 
// каждый раз повторяя цифру столько раз, сколько она значит.


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void printNum(int num)
{
    int i = 0;                              // Счетчик для группы одинаковых чисел
    int count = 0;                          // Счетчик для подсчета количества чисел
    while (true)                            // Цикл, который считает группы
    {
        for (int j = 0; j < i; j++)         // Цикл выводит числа в группе
        {
            System.Console.Write($"{i}");   // Вывод числа
            count++;
            if (count == num)               // Условие выхода
            {
                return;
            }
        }
        i++;                                // Счетчик групп
    }
}

int number = Prompt("Введите число ");
printNum(number);