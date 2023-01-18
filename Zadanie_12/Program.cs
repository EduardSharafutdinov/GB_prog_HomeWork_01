// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA <=99) Console.WriteLine("Вы ввели число где нет третьей цифры. Повторите ввод.");

if (numberA >99)
{
int numberB = numberA % 10;
Console.Write("Третья цифра введеного Вами числа = ");
Console.WriteLine(numberB);
}
