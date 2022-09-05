// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matrix[i, j] = new Random().Next(1, 10);
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

int[,] SortFromMaxToMinInRow(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (result[i, j - 1] < result[i, j])
            {
                int temp = result[i, j];
                result[i, j] = result[i, j - 1];
                result[i, j - 1] = temp;
                j = 0;
            }
        }
    }
    return result;
}

int numRows = Prompt("Введите количество строк ");
int numColumns = Prompt("Введите количество столбцов ");
if (IsCorect(numRows, numColumns))
{
    int[,] matrix = FillArray(numRows, numColumns);
    PrintBidimentionalArray(matrix);
    System.Console.WriteLine();
    int[,] result = SortFromMaxToMinInRow(matrix);
    PrintBidimentionalArray(result);
}
else
{
    Console.WriteLine("Данные введены некорректно");
}