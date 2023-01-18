// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Дано число из отрезка  от 10 до 99: ");
int numberA = Convert.ToInt32(new Random().Next(10, 99));    //10 11 12 13 .... 99
Console.WriteLine(numberA);

int numberB = numberA % 10;
int numberC = (numberA % 100 - numberA % 10) / 10;
int max = 0;

if (numberB > numberC) max = numberB;
if (numberC > numberB) max = numberC;

Console.WriteLine("Наибольшая цифра в данном числе: ");
Console.WriteLine(max);
