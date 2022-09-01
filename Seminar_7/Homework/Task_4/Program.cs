// Задача 4. Со звездочкой(*). Найдите максимальное значение 
// в матрице по каждой строке, суммируйте их. Затем найдите 
// минимальное значение по каждой колонке, тоже суммируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int[] FindMaxInRow(int[,] array)
{
    int[] maxInEachRow = new int[array.GetLength(1)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int max = array[row, 0];
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (array[row, column] > max)
            {
                max = array[row, column];
            }
        }
        maxInEachRow[row] = max;
    }
    return maxInEachRow;
}

int[] FindMinInEachColumn(int[,] array)
{
    int[] minInEachColumn = new int[array.GetLength(0)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        int min = array[0, column];
        for (int row = 0; row < array.GetLength(0); row++)
        {
            if (array[row, column] < min)
            {
                min = array[row, column];
            }
        }
        minInEachColumn[column] = min;
    }
    return minInEachColumn;
}

int SumOfItems(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

int SubtractMinFromMax(int max, int min)
{
    int deviationMaxMin = max - min;
    return deviationMaxMin;
}


int numRows = Prompt("Введите количество строк ");
int numColumns = Prompt("Введите количество столбцов ");
if (IsCorect(numRows, numColumns))
{
    int[,] matrix = FillArray(numRows, numColumns);
    PrintBidimentionalArray(matrix);

    int[] maxInEachRow = FindMaxInRow(matrix);
    System.Console.WriteLine();
    Console.WriteLine($"Максимальное число в каждой строке:");
    PrintArray(maxInEachRow);
    int sumOfMax = SumOfItems(maxInEachRow);
    Console.WriteLine($"Сумма максимальных чисел в каждой строке равна {sumOfMax}");

    int[] minInEachColumn = FindMinInEachColumn(matrix);
    System.Console.WriteLine();
    Console.WriteLine($"Минимальное число в каждой колонке:");
    PrintArray(minInEachColumn);
    int sumOfMin = SumOfItems(minInEachColumn);
    Console.WriteLine($"Сумма минимальных чисел в каждой колонке равна {sumOfMin}");

    System.Console.WriteLine();
    int deviationMaxMin = SubtractMinFromMax(sumOfMax, sumOfMin);
    System.Console.WriteLine($"Разница между суммой с максимумами и суммой с минимумами равна {deviationMaxMin}");
    System.Console.WriteLine();
}
else
{
    Console.WriteLine("Данные введены некорректно");
}