// 1. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = Prompt("Введите x ");
int y = Prompt("Введите y ");

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Невозможно вычислить четверть, точка на оси");
    return;
}

int quarter = GetQuarter(x, y);
System.Console.WriteLine(quarter);