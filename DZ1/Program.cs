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

void PrintNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }

    if (M % 2 == 0)
    {
       Console.Write(M + " "); 
    }
    PrintNumbers(M+1, N);
}

int numM = Prompt("Введите M");
int numN = Prompt("Введите N");
PrintNumbers(numM, numN);
Console.ReadLine();

