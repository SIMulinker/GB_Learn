// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine(" Введите граничное число");

int numbers = Math.Abs( int.Parse( Console.ReadLine()!));
// можно было конечно ещё через регулярку проверить на числовое содержимое и рамерность .... ;)
int i;
for ( i = 1;  i < numbers ; i++)
{
    Console.Write(Math.Pow(i,3) + ", ");
}
Console.WriteLine(Math.Pow(i,3));
