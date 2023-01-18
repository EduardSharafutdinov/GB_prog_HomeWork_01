// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число на которое будем проверять кратность: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(new Random().Next(1, 10));
Console.WriteLine(numberB);

double numberC = (double)numberB / numberA;

if (numberB % numberA != 0) Console.WriteLine("Число не кратно введеному Вами значанию и равняется: ");
Console.WriteLine(numberC);
if (numberB % numberA == 0) Console.WriteLine("Поздравляю! Число кратно введеному Вами значению!");
