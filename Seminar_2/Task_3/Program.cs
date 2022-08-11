// 3. Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1;
int num2;
int remainder;

num1 = Prompt("Введите первое число ");
num2 = Prompt("Введите второе число ");
remainder = num1 % num2;

if (remainder == 0)
{
    System.Console.WriteLine($"{num2} кратно {num1}");
}
else
{
    System.Console.WriteLine($"{num2} некратно {num1}, остаток от деления {remainder}");
}