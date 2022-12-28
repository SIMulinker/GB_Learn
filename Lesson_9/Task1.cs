/*
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
*/


Console.Write("Enter the N ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(AllToN(N));   

string AllToN( int n)
{
    if ( n== 1)
    {
        return n.ToString();
    }
    else
    {
        return n.ToString() + ", " + AllToN(n-1);
    }
}
