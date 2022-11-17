/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int Prompt(string msg)
{
    Console.Write(msg + " => ");
    return int.Parse(Console.ReadLine());
}

int AkkermanFunc(int n, int m)
{
    if (n < 0 || m < 0)
        throw new ArgumentOutOfRangeException();
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AkkermanFunc(n - 1, 1);
    else
        return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}
int numM = Prompt("Введите m");
int numN = Prompt("Введите n");
int A = AkkermanFunc(numM, numN);
Console.WriteLine(A);