// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine(PrintNumber(10, 1));

string PrintNumber(int end, int start)
{
    if (end == start)
    {
        return end.ToString();
    }
    return (end + " " + PrintNumber(end - 1, start));
}
