// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsCorect(int numRows1, int numColumns1, int numRows2, int numColumns2)
{
    if (numRows1 > 0 && numColumns1 > 0 && numRows2 > 0 && numColumns2 > 0)
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

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return matrix;
}

int numRows1 = Prompt("Введите количество строк первой матрицы ");
int numColumns1 = Prompt("Введите количество столбцов первой матрицы ");
int numRows2 = Prompt("Введите количество строк второй матрицы ");
int numColumns2 = Prompt("Введите количество столбцов второй матрицы ");
if (IsCorect(numRows1, numColumns1, numRows2, numColumns2))
{
    int[,] matrix1 = FillArray(numRows1, numColumns1);
    PrintBidimentionalArray(matrix1);
    Console.WriteLine();
    int[,] matrix2 = FillArray(numRows2, numColumns2);
    PrintBidimentionalArray(matrix2);
    Console.WriteLine();

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Массивы несовместимы для умножения");
    }
    else
    {
        int[,] result = MultiplicationMatrix(matrix1, matrix2);
        Console.WriteLine("Произведение двух матриц ");
        PrintBidimentionalArray(result);
    }
}
else
{
    Console.WriteLine("Данные введены некорректно");
}

