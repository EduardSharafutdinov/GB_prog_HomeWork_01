// Показать вторую цифру трёхзначного числа

Console.Write("Введите любое трехзначное число в диапазоне от 100 до 999: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = (numberA % 100 - numberA % 10) / 10;

Console.WriteLine(numberB);
