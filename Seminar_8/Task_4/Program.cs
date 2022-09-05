// Задача 4: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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


int[] MinElementIndex(int[,] array)
{
    int[] answer = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[answer[0], answer[1]])
            {
                answer[0] = i;
                answer[1] = j;
            }
        }
    }
    return answer;
}

int[,] DelitRowColumn(int[,] array)
{
    int[] MinIndexes = MinElementIndex(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int l = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (row != MinIndexes[0] && column != MinIndexes[1])
            {
                result[k, l] = array[row, column];
                l++;
            }
        }
        if (row != MinIndexes[0])
            k++;
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
    int[,] result = DelitRowColumn(matrix);
    PrintBidimentionalArray(result);
}
else
{
    Console.WriteLine("Данные введены некорректно");
}