// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine(SumNumbers(1, 15));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        n += SumNumbers(m, n - 1);
    }
    return n;
}