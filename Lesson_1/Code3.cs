//убедиться что введёное число чётное
Console.Write(" Введите проверяемое число: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 % 2 == 0)
{
    Console.WriteLine(" Введёное число чётное !");
}
else
{
    Console.WriteLine(" Введёное число чётным не является ..");
}