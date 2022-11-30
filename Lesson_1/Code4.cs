// вывести все чётные числа по введёное включительно
Console.Write(" Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

bool first = false;

for (int i = 1; i <= num1; i++)
{
    if (i % 2 == 0)
    {
        if (first == true)
        { Console.Write(" , " + i); }
        else { first = true; }
    }
}