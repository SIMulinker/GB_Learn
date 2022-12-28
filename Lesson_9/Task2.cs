/*
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/




Console.Write("Enter the M ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter the N ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(SumFromMToN(M,N));   


int SumFromMToN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumFromMToN(m + 1, n) ;
    }
}
