// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Prompt($"Введите {i} элемент ");
        }
    }
    return array;
}

int CountPositive(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}

int elementsCount = Prompt("Сколько чисел Вы хотите ввести? ");
if (elementsCount > 0)
{
    int[] array = CreateArray(elementsCount);
    int sum = CountPositive(array);
    Console.WriteLine($"Количество положительнх чисел среди введенных Вами равно {sum}");
}
else
{
    Console.WriteLine("Число введено некорректно ");
}