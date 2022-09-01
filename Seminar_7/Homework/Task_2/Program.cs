// Задача 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] FillArray(int numrows, int numcolumns)
{
    int[,] matrix = new int[numrows, numcolumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] numbers)
{
    for (int rows = 0; rows < numbers.GetLength(0); rows++)
    {
        for (int columns = 0; columns < numbers.GetLength(1); columns++)
        {
            System.Console.Write($"{numbers[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}

bool IsCorect(int itemRow, int itemColumn)
{
    if (itemRow > 0 && itemColumn > 0)
    {
        return true;
    }
    return false;
}

void FindItem(int[,] array, int itemRow, int itemColumn)
{
    if (itemRow >= array.GetLength(0) || itemColumn >= array.GetLength(1))
    {
        Console.WriteLine("Позиция не найдена");
        return;
    }

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (array[itemRow, itemColumn] == array[row, column])
            {
                Console.WriteLine($"На позиции [{itemRow}, {itemColumn}] находится число {array[row, column]}");
                return;
            }
        }
    }
}

int numRows = Prompt("Введите количество строк ");
int numColumns = Prompt("Введите количество столбцов ");

if (IsCorect(numRows, numColumns))
{
    int[,] matrix = FillArray(numRows, numColumns);
    PrintArray(matrix);
    FindItem(matrix, Prompt("Введите индекс строки "), Prompt("Введите индекс столбца "));
}
else
{
    Console.WriteLine("Данные введены некорректно");
}