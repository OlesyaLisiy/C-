// Задача 2: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void FindIntersection(double k1, double b1, double k2, double b2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        (double x, double y) = FindCoordinates(k1, b1, k2, b2);
        Console.WriteLine($"Координаты точки пересечения прямых ({x:f2}; {y:f2})");
    }
    (double, double) FindCoordinates(double k1, double b1, double k2, double b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return (x, y);
    }
}

FindIntersection(Prompt("Введите коэффициэнт k1 "), Prompt("Введите коэффициэнт b1 "), Prompt("Введите коэффициэнт k2 "), Prompt("Введите коэффициэнт k1 "));