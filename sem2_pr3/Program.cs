// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (n == 6 || n == 7)
    {
         Console.WriteLine("Это выходной день");
    }
    else 
    {
         Console.WriteLine("Это не выходной");
    }
}