/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/

Console.Write("Enter the M ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter the N ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(FunctionAkkerman(M,N));


int FunctionAkkerman(int M, int N)
{
    if(M ==0) 
        return N+1;
    else if(N==0 && M >0) 
        return FunctionAkkerman(M-1,1);
    else 
        return FunctionAkkerman(M-1,FunctionAkkerman(M,N-1));
}
