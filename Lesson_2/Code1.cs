// принимает на вход трёхзначное число и выдаёт вторую цифру
Console.Write(" Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine()!);

if ((num1 >= 100) && (num1 < 1000))
{
    int num_up = num1 % 100;
    num1 = num_up / 10;
    Console.Write(" Вторая цифра: " + num1);
}
else
{
    Console.Write(" не трёхзначное число ");
}