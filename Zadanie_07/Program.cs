// Показать последнюю цифру трёхзначного числа

Console.Write("Введите любое трехзначное число от 100 до 999: ");
int numberA = Convert.ToInt16(Console.ReadLine());

int numberB = numberA % 10;
Console.Write("Последняя цифра Вашего числа = ");
Console.WriteLine(numberB);

