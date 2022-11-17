/* 
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/
Start:
int Prompt(string msg)
{
    Console.Write(msg + " => ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int M, int N, int sum)
{
    if (M > N)
    {
        return 0;
    }
    return M + PrintNumbers(M + 1, N, sum);
    //Console.Write(sum + " ");
}

int numM = Prompt("Введите M");
int numN = Prompt("Введите N");
int sum = PrintNumbers(numM, numN, 0);
Console.WriteLine(sum);
goto Start;
