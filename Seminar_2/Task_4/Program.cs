// 4. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num;

num = Prompt("Введите число ");
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"{num} одновременно кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{num} некратно одновременно 7 и 23");
}