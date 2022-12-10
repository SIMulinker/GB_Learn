// принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Write("Function started ! \n\rEnter A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Enter B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("   " + Power(A, B));

int Power(int bases, int expo)
{
    int result = 1;
    for (int i = 1; i <= expo; i++)
    {
        result *= bases;
    }
    return result;
}
