
Console.Write(" Введите число обозначающее день недели: ");
int num1 = int.Parse(Console.ReadLine()!);

if ((num1 > 0) && (num1 < 8))
{
    if ((num1 == 6) || (num1 == 7))
    {
        Console.Write(" Выходной ");
    }
    else
    {
        Console.Write(" Нет. ");
    }
}
else
{
    Console.Write(" число не определяет день недели ");
}