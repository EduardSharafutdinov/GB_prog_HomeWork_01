// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите любое трёхзначное число, а Я спрячу у него вторую цифру");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = numberA % 10;
int numberC = (numberA % 100 - numberA % 10) / 10;
int numberD = (numberA % 1000 - numberA % 100) / 100;

Console.Write(numberD); Console.Write(" "); Console.Write(numberB);



