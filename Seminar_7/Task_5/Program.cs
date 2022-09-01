// Задача 4: Задайте двумерный массив. 
// Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.


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

void FindItem(int[,] array, int item)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (item == array[row, column])
            {
                Console.WriteLine($"Введенный элемент находится на позиции [{row}, {column}]");
                return;
            }
        }
    }
    Console.WriteLine("Элемент не найден");
}

int[,] matrix = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
PrintArray(matrix);
FindItem(matrix, Prompt("Введите число "));
