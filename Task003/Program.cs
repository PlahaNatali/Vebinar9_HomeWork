// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine(FunctionAckerman(3, 2));

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        n = FunctionAckerman(m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = FunctionAckerman(m, n - 1);
        n = FunctionAckerman(m - 1, n);
    }
    return n;
}