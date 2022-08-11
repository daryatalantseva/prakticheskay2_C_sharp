// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int n;
n = Convert.ToInt32(Console.ReadLine());
int a = 0;
if (n < 100)
{
    Console.WriteLine("В числе нет третьей цифры");

}
else
{
    while (n >= 100)
    {
        a = n % 10;
        n = n / 10;
    }
    
    Console.WriteLine(a);
}