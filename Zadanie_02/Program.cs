// По двум заданным числам проверять является ли первое квадратом второго

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());


if(numberA == numberB * numberB)
Console.WriteLine("Yes! Первое число, является квадратом второго числа.");
if(numberA != numberB * numberB)
Console.WriteLine("No! Первое число, не является квадратом второго числа.");
