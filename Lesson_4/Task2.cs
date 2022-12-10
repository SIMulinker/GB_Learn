// принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("I'm started! \n\rEnter the numbers: ");
int numbers = int.Parse(Console.ReadLine()!);

Console.Write("Result :" + SumNumbers(numbers));

int SumNumbers(int ToCounts)
{
    int iterate = 0;
    for (; ToCounts > 0; ToCounts /= 10)
    {
        iterate += ToCounts % 10;
    }
    return iterate;
}
