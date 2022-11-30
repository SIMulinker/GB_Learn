
Console.Write(" Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 >= 100 )
{
    int num_up = num1 % 1000;
    num1 = num_up / 100;
    Console.Write(" Третья цифра: " + num1);
}
else
{
    Console.Write(" меньше трёх цифр ");
}