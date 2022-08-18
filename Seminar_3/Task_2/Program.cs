// Задача 2: Напишите программу, которая по заданному
// номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void GetCoordinate(int q)
{
    if (q == 1)
    {
        System.Console.WriteLine("x > 0, y > 0");
    }

    else if (q == 2)
    {
        System.Console.WriteLine("x < 0, y > 0");
    }

    else if (q == 3)
    {
        System.Console.WriteLine("x < 0, y < 0");
    }

    else if (q == 4)
    {
        System.Console.WriteLine("x > 0, y < 0");
    }

    else
    {
        System.Console.WriteLine("Невозможно вычислить диапазон координат, четверть задана некорректно");
    }
}

GetCoordinate(Prompt("Введите номер четверти "));
