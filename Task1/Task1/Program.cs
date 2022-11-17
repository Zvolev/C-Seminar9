/* 
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Prompt(string msg)
{
    Console.Write(msg + " => ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int number)
{
    if (number <= 0)
    {
        return;
    }

    PrintNumbers(number - 1);
    Console.Write(number + " ");
}
int num = Prompt("Введите число");
PrintNumbers(num);
Console.ReadLine();