// адача 2: Задайте двумерный массив. Найдите элементы, 
// у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4


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

int[,] ChangeToSquare(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (row % 2 == 1 && column % 2 == 1)
                array[row, column] = array[row, column] * array[row, column];
        }
    }
    return array;
}

int[,] matrix = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
PrintArray(matrix);
Console.WriteLine();
ChangeToSquare(matrix);
PrintArray(matrix);