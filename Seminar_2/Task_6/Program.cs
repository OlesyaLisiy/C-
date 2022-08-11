// 3.1. Напишите программу, которая будет принимать 
// на вход пять чисел и выводить сумму 
// и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Prompt($"Введите {i} элемент ");
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}

double avg = sum / ((double)array.Length);

System.Console.WriteLine($"Сумма равна {sum} а среднее равно {avg}");
