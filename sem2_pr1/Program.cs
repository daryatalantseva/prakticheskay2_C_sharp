// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int n;
n = Convert.ToInt32(Console.ReadLine());
if ( n < 100)
{
    Console.WriteLine("Данное число не является трехзначным");
}
else
{
    Console.WriteLine( n % 100 / 10) ;
}