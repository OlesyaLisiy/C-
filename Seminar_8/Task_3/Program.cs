// Задача 3: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i} - {array[i]}\t");
    }
    Console.WriteLine();
}

int[] FrequencyDictionary(int[,] array)
{
    int[] result = new int[10];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = row; column < array.GetLength(1); column++)
        {
            result[array[row, column]]++;
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
    int[] result = FrequencyDictionary(matrix);
    PrintArray(result);
}
else
{
    Console.WriteLine("Данные введены некорректно");
}