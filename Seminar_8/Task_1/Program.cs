// Задача 1: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsCorect(int numRows, int numColumns)
{
    if (numRows > 0 && numColumns > 0)
    {
        return true;
    }
    return false;
}

int[,] FillArray(int numrows, int numcolumns)
{
    int[,] matrix = new int[numrows, numcolumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}

void PrintBidimentionalArray(int[,] numbers)
{
    for (int rows = 0; rows < numbers.GetLength(0); rows++)
    {
        for (int columns = 0; columns < numbers.GetLength(1); columns++)
        {
            System.Console.Write($"{numbers[rows, columns]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeRowColumn(int[,] array)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        int temp = array[0, column];
        array[0, column] = array[array.GetLength(0) - 1, column];
        array[array.GetLength(0) - 1, column] = temp;
    }
    return array;
}

int numRows = Prompt("Введите количество строк ");
int numColumns = Prompt("Введите количество столбцов ");
if (IsCorect(numRows, numColumns))
{
    int[,] matrix = FillArray(numRows, numColumns);
    PrintBidimentionalArray(matrix);
    ChangeRowColumn(matrix);
    Console.WriteLine($"Новый массив:");
    PrintBidimentionalArray(matrix);
}
else
{
    Console.WriteLine("Данные введены некорректно");
}