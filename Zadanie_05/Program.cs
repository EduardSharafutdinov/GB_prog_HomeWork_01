// Выяснить является ли число чётным

Console.Write("Введите число для проверки: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberA);

if (numberA%2 != 0)
{
    Console.Write("Данное число является не четным");
}
else
{
    Console.Write("Данное число является четным");
}